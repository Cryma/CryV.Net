#include "EntryPoint.h"

bool GetTextLabel(const char* label, std::string& customLabel)
{
    if (strcmp(label, "LOADING_SPLAYER_L") == 0)
    {
        customLabel = "Loading CryV Multiplayer";

        return true;
    }

    return false;
}

void Main()
{
    CryV::Main::LoadCryVLibrary();

    while (true)
    {
        scriptWait(0);
    }
}

void EntryPoint()
{
    startHook(GetModuleHandle(nullptr), Main, GetTextLabel);
}
