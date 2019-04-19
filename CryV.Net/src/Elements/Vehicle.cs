using System.Net.Http.Headers;
using System.Numerics;
using CryV.Net.Client.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements
{
    public class Vehicle : Entity
    {

        public float WheelSpeed
        {
            get => CryVNative.Native_Memory_GetWheelSpeed(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetWheelSpeed(CryVNative.Plugin, Handle, value);
        }

        public byte CurrentGear
        {
            get => CryVNative.Native_Memory_GetCurrentGear(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetCurrentGear(CryVNative.Plugin, Handle, value);
        }

        public float CurrentRPM
        {
            get => CryVNative.Native_Memory_GetCurrentRPM(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetCurrentRPM(CryVNative.Plugin, Handle, value);
        }

        public float Clutch
        {
            get => CryVNative.Native_Memory_GetClutch(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetClutch(CryVNative.Plugin, Handle, value);
        }

        public float Turbo
        {
            get => CryVNative.Native_Memory_GetTurbo(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetTurbo(CryVNative.Plugin, Handle, value);
        }

        public float Acceleration
        {
            get => CryVNative.Native_Memory_GetAcceleration(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetAcceleration(CryVNative.Plugin, Handle, value);
        }

        public float Brake
        {
            get => CryVNative.Native_Memory_GetBrake(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetBrake(CryVNative.Plugin, Handle, value);
        }

        public float SteeringAngle
        {
            get => CryVNative.Native_Memory_GetSteeringAngle(CryVNative.Plugin, Handle);
            set => CryVNative.Native_Memory_SetSteeringAngle(CryVNative.Plugin, Handle, value);
        }

        public Vehicle(int handle) : base(handle)
        {
        }

        public Vehicle(ulong model, Vector3 position, Vector3 rotation) : base(0)
        {
            CreateVehicle(model, position, rotation);
        }

        public bool GetIsVehicleEngineRunning()
        {
            return CryVNative.Native_Vehicle_GetIsVehicleEngineRunning(CryVNative.Plugin, Handle);
        }

        public void SetVehicleEngineOn(bool value, bool instantly, bool otherwise = true)
        {
            CryVNative.Native_Vehicle_SetVehicleEngineOn(CryVNative.Plugin, Handle, value, instantly, otherwise);
        }

        public Ped GetPedOnSeat(int seat)
        {
            return new Ped(CryVNative.Native_Vehicle_GetPedInVehicleSeat(CryVNative.Plugin, Handle, seat));
        }

        public void StartVehicleHorn(int duration)
        {
            CryVNative.Native_Vehicle_StartVehicleHorn(CryVNative.Plugin, Handle, duration, Utility.Joaat("HELDDOWN"), false);
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
