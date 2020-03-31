#include "CryV.h"

void CryV::Main::LoadCryVLibrary()
{
    auto assembly = Assembly::LoadFile("C:\\Development\\CryV\\client\\CryV.Net.dll");
    auto type = assembly->GetType("CryV.Net.PluginWrapper");

    auto methodInfo = type->GetMethod("PluginMain", BindingFlags::Public | BindingFlags::Static);

    auto parameters = gcnew array<Object^>(0);

    methodInfo->Invoke(nullptr, parameters);
}

String^ CryV::Main::GetSomething()
{
    return "poggers";
}
