#pragma once

#include <Windows.h>
#include <sdk/main.h>
using namespace System;
using namespace System::Reflection;

namespace CryV {
    public ref class Main
    {
    public:
        static void LoadCryVLibrary();

        static String^ GetSomething();
    };
}
