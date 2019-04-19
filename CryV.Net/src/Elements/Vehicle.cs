using System.Numerics;
using CryV.Net.Client.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements
{
    public class Vehicle : Entity
    {

        public Vehicle(int handle) : base(handle)
        {
        }

        public Vehicle(ulong model, Vector3 position, Vector3 rotation) : base(0)
        {
            CreateVehicle(model, position, rotation);
        }

        public Ped GetPedOnSeat(int seat)
        {
            return new Ped(CryVNative.Native_Vehicle_GetPedInVehicleSeat(CryVNative.Plugin, Handle, seat));
        }

        private void CreateVehicle(ulong model, Vector3 position, Vector3 rotation)
        {
            if (IsValid())
            {
                Delete();
            }

            Streaming.LoadModel(model);

            Handle = CryVNative.Native_Vehicle_CreateVehicle(CryVNative.Plugin, model, position.X, position.Y, position.Z, rotation.Z, false, false);
            EntityPool.AddEntity(this);

            Utility.Wait(0);

            Rotation = rotation;

            Streaming.UnloadModel(model);
        }

    }
}
