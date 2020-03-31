#pragma once

#include <d3d11.h>

#include <sdk/enums.h>
#include <sdk/types.h>
#include <nativeInvoker.h>

#include <vmtHook.h>

namespace hook {
    class GamePatterns {
    public:
        typedef void(__cdecl *NativeHandler)(ScrNativeCallContext *context);

    private:
        struct NativeRegistrationNew;
        typedef const char*(GetLabelText) (void *unk, const char *label);

        uint64_t *_frameCount;
        eGameState *_gameState;
        CReplayInterface *_replayInterface;
        IDXGISwapChain *_swapchain;
        char *_addressToEntity;
        NativeRegistrationNew **_registrationTable;
        GetLabelText *_getLabelText;

    public:
        GamePatterns();

        void initialize();

        int addressToEntity(void *address);
        CReplayInterface *replayInterface() const;
        IDXGISwapChain *swapChain() const;
        NativeRegistrationNew **registrationTable() const;
        GetLabelText *getLabelText() const;
        eGameState *gameState() const;

    private:
        struct NativeRegistrationNew {
            uint64_t nextRegistration1;
            uint64_t nextRegistration2;
            NativeHandler handlers[7];
            uint32_t numEntries1;
            uint32_t numEntries2;
            uint64_t hashes;

            NativeRegistrationNew* getNextRegistration() {
                uintptr_t result;
                auto v5 = reinterpret_cast<uintptr_t>(&nextRegistration1);
                auto v12 = 2i64;
                const auto v13 = v5 ^ nextRegistration2;
                const auto v14 = reinterpret_cast<char *>(&result) - v5;
                do {
                    *reinterpret_cast<DWORD*>(&v14[v5]) = (DWORD) v13 ^ *reinterpret_cast<DWORD*>(v5);
                    v5 += 4i64;
                    --v12;
                } while (v12);

                return reinterpret_cast<NativeRegistrationNew*>(result);
            }

            uint32_t getNumEntries() {
                return (uint32_t) reinterpret_cast<uintptr_t>(&numEntries1) ^ numEntries1 ^ numEntries2;
            }

            uint64_t getHash(uint32_t index) {

                auto naddr = 16 * index + reinterpret_cast<uintptr_t>(&nextRegistration1) + 0x54;
                auto v8 = 2i64;
                uint64_t nResult;
                auto v11 = (char *) &nResult - naddr;
                auto v10 = naddr ^ *(DWORD*) (naddr + 8);
                do {
                    *(DWORD *) &v11[naddr] = (DWORD) v10 ^ *(DWORD*) (naddr);
                    naddr += 4i64;
                    --v8;
                } while (v8);

                return nResult;
            }
        };


        enum eThreadState {
            ThreadStateIdle = 0x0,
            ThreadStateRunning = 0x1,
            ThreadStateKilled = 0x2,
            ThreadState3 = 0x3,
            ThreadState4 = 0x4,
        };

        struct scrThreadContext {
            int ThreadID;
            int ScriptHash;
            eThreadState State;
            int _IP;
            int FrameSP;
            int _SPP;
            float TimerA;
            float TimerB;
            int TimerC;
            int _mUnk1;
            int _mUnk2;
            int _f2C;
            int _f30;
            int _f34;
            int _f38;
            int _f3C;
            int _f40;
            int _f44;
            int _f48;
            int _f4C;
            int _f50;
            int pad1;
            int pad2;
            int pad3;
            int _set1;
            int pad[17];
        };

        struct scrThread {
            void *vTable;
            scrThreadContext m_ctx;
            void *m_pStack;
            void *pad;
            void *pad2;
            const char *m_pszExitMessage;
        };

        struct ScriptThread : scrThread {
            const char Name[64];
            void *m_pScriptHandler;
            const char gta_pad2[40];
            const char flag1;
            const char m_networkFlag;
            bool bool1;
            bool bool2;
            bool bool3;
            bool bool4;
            bool bool5;
            bool bool6;
            bool bool7;
            bool bool8;
            bool bool9;
            bool bool10;
            bool bool11;
            bool bool12;
            const char gta_pad3[10];
        };
    };
}