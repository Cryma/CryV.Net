using System.Numerics;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public class Ped : Entity
    {

        public Ped(int handle) : base(handle)
        {
        }

        public Ped(string skin, Vector3 position, float heading) : base(0)
        {
            var model = Utility.GetHashKey(skin);
            Streaming.RequestModel(model);
            while (Streaming.HasModelLoaded(model) == false)
            {
                Utility.Wait(0);
            }

            Handle = CryVNative.Native_Ped_CreatePed(CryVNative.Plugin, 26, model, position.X, position.Y, position.Z, heading, false, false);
            EntityPool.AddEntity(this);

            Utility.Wait(0);

            SetPedDefaultComponentVariation();

            Streaming.SetModelAsNoLongerNeeded(model);
        }

        public void SetPedDefaultComponentVariation()
        {
            if (DoesExist() == false)
            {
                Utility.Log("SetPedDefaultComponentVariation - Ped does not exist?");

                return;
            }

            Utility.Log("Ped id: " + Handle);

            CryVNative.Native_Ped_SetPedDefaultComponentVariation(CryVNative.Plugin, Handle);
        }

    }
}