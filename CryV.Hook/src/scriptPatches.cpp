#include "scriptPatches.h"

#include "memory/signature.h"

void hook::ScriptPatches::patchMultiplayerVehicles() {
    GlobalTable globalTable{};

    auto globalBasePointer = memory::Signature("4C 8D 05 ? ? ? ? 4D 8B 08 4D 85 C9 74 11").scan().as<uintptr_t>();
    globalTable.GlobalBasePtr = (__int64**)(globalBasePointer + *(int*)(globalBasePointer + 3) + 7);

    ScriptTable *scriptTable{};

    auto scriptTablePointer = memory::Signature("48 03 15 ? ? ? ? 4C 23 C2 49 8B 08").scan().as<uintptr_t>();

    scriptTable = (ScriptTable*)(scriptTablePointer + *(int*)(scriptTablePointer + 3) + 7);
    while(globalTable.isInitialised() == false) {
        Sleep(50);
    }

    ScriptTableItem *item = scriptTable->findScript(0x39DA738B);
    if(item == nullptr) {
        return;
    }

    while(item->isLoaded() == false) {
        Sleep(50);
    }

    auto scriptHeader = item->Header;

    for(auto i = 0; i < scriptHeader->codePageCount(); i++) {
        auto size = scriptHeader->getCodePageSize(i);
        if(size) {
            memory::MemoryRegion region(memory::MemoryHandle(scriptHeader->getCodePageAddress(i)), size);
            auto address = memory::Signature("2D ? ? 00 00 2C 01 ? ? 56 04 00 6E 2E ? 01 5F ? ? ? ? 04 00 6E 2E ? 01").scan(region).as<uintptr_t>();
            if(address) {
                auto globalIndex = *(int*)(address + 17) & 0xFFFFFF;
                *globalTable.addressOf(globalIndex) = 1;

                return;
            }
        }
    }
}
