using CryV.Net.Client.Native;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryV.Net.Client.Elements
{
    public static class LocalPlayer
    {

        public static int PlayerId()
        {
            return CryVNative.Native_LocalPlayer_PlayerId(PluginWrapper.Plugin);
        }

        public static int PedId()
        {
            return CryVNative.Native_LocalPlayer_PedId(PluginWrapper.Plugin);
        }

        public static void SetPosition(float x, float y, float z)
        {
            CryVNative.Native_Entity_SetEntityPosition(PluginWrapper.Plugin, PedId(), x, y, z);
        }

    }
}
