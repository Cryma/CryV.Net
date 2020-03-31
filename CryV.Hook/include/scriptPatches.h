#pragma once

#include <Windows.h>

namespace hook {
    struct ScriptHeader {
        char padding1[16];
        unsigned char** codeBlocksOffset;
        char padding2[4];
        int codeLength;
        char padding3[4];
        int localCount;
        char padding4[4];
        int nativeCount;
        __int64* localOffset;
        char padding5[8];
        __int64* nativeOffset;
        char padding6[16];
        int nameHash;
        char padding7[4];
        char* name;
        char** stringsOffset;
        int stringSize;
        char padding8[12];

        bool isValid() const { return codeLength > 0; }
        int codePageCount() const { return (codeLength + 0x3FFF) >> 14; }
        int getCodePageSize(int page) const {
            return (page < 0 || page >= codePageCount() ? 0 : (page == codePageCount() - 1) ? codeLength & 0x3FFF : 0x4000);
        }
        unsigned char* getCodePageAddress(int page) const { return codeBlocksOffset[page]; }
        unsigned char* getCodePositionAddress(int codePosition) const {
            return codePosition < 0 || codePosition >= codeLength ? NULL : &codeBlocksOffset[codePosition >> 14][codePosition & 0x3FFF];
        }
        char* getString(int stringPosition)const {
            return stringPosition < 0 || stringPosition >= stringSize ? NULL : &stringsOffset[stringPosition >> 14][stringPosition & 0x3FFF];
        }

    };

    struct ScriptTableItem {
        ScriptHeader* Header;
        char padding[4];
        int hash;

        inline bool isLoaded() const {
            return Header != NULL;
        }
    };

    struct ScriptTable {
        ScriptTableItem* TablePtr;
        char padding[16];
        int count;
        ScriptTableItem* findScript(int hash) {
            if (TablePtr == NULL) {
                return NULL;
            }
            for (int i = 0; i < count; i++) {
                if (TablePtr[i].hash == hash) {
                    return &TablePtr[i];
                }
            }
            return NULL;
        }
    };

    struct GlobalTable {
        __int64** GlobalBasePtr;
        __int64* addressOf(int index) const { return &GlobalBasePtr[index >> 18 & 0x3F][index & 0x3FFFF]; }
        bool isInitialised()const { return *GlobalBasePtr != NULL; }
    };

    struct HashNode {
        int hash;
        UINT16 data;
        UINT16 padding;
        HashNode* next;
    };

    class ScriptPatches {
    public:
        static void patchMultiplayerVehicles();
    };
}
