#include "framework.h"

#include <string>

typedef void(*EntryPoint)();

DWORD WINAPI Startup(LPVOID)
{
    auto dll = LoadLibrary("C:\\Development\\CryV\\client\\CryV.dll");

    auto entryPoint = (EntryPoint)GetProcAddress(dll, "EntryPoint");

    entryPoint();

    return TRUE;
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    {
        DisableThreadLibraryCalls(hModule);

        CreateThread(nullptr, NULL, static_cast<LPTHREAD_START_ROUTINE>(Startup), nullptr, NULL, nullptr);

        break;
    }
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
