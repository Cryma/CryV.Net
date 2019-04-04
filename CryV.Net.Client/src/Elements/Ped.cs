using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public class Ped : Entity
    {

        public Ped(int handle) : base(handle)
        {
        }

        public void SetPedDefaultComponentVariation()
        {
            CryVNative.Native_Ped_SetPedDefaultComponentVariation(CryVNative.Plugin, Handle);
        }

    }
}