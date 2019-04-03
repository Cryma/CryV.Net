using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public static class Utility
    {

        public static void Log(string message)
        {
            using (var converter = new StringConverter())
            {
                var messagePointer = converter.StringToPointer(message);

                CryVNative.Native_Utility_Log(CryVNative.Plugin, messagePointer);
            }
        }

    }
}