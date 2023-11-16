using System.Numerics;
using CryV.Net.Enums;
using CryV.Net.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements;

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

    public bool IsDriveable
    {
        get => CryVNative.Native_Vehicle_IsVehicleDriveable(CryVNative.Plugin, Handle, false);
        set => CryVNative.Native_Vehicle_SetVehicleUndriveable(CryVNative.Plugin, Handle, value == false);
    }

    public string? NumberPlate
    {
        get => StringConverter.PointerToString(CryVNative.Native_Vehicle_GetVehicleNumberPlateText(CryVNative.Plugin, Handle), false);
        set
        {
            if (value == null)
            {
                return;
            }

            using var converter = new StringConverter();
            var stringPointer = converter.StringToPointer(value);

            CryVNative.Native_Vehicle_SetVehicleNumberPlateText(CryVNative.Plugin, Handle, stringPointer);
        }
    }

    public float DirtLevel
    {
        get => CryVNative.Native_Vehicle_GetVehicleDirtLevel(CryVNative.Plugin, Handle);
        set => CryVNative.Native_Vehicle_SetVehicleDirtLevel(CryVNative.Plugin, Handle, value);
    }

    public float BodyHealth
    {
        get => CryVNative.Native_Vehicle_GetVehicleBodyHealth(CryVNative.Plugin, Handle);
        set => CryVNative.Native_Vehicle_SetVehicleBodyHealth(CryVNative.Plugin, Handle, value);
    }

    public float EngineHealth
    {
        get => CryVNative.Native_Vehicle_GetVehicleEngineHealth(CryVNative.Plugin, Handle);
        set
        {
            CryVNative.Native_Vehicle_SetVehicleEngineHealth(CryVNative.Plugin, Handle, value);

            if (EngineHealth < 0.0f)
            {
                Explode(false, true);
            }
        }
    }

    public bool Siren
    {
        get => CryVNative.Native_Vehicle_IsVehicleSirenOn(CryVNative.Plugin, Handle);
        set => CryVNative.Native_Vehicle_SetVehicleSiren(CryVNative.Plugin, Handle, value);
    }

    public ulong Model => CryVNative.Native_Entity_GetEntityModel(CryVNative.Plugin, Handle);

    public Vehicle(int handle) : base(handle)
    {
    }

    public Vehicle(ulong model, Vector3 position, Vector3 rotation, Vector3 velocity, int colorPrimary, int colorSecondary, string? numberPlate) : base(0)
    {
        CreateVehicle(model, position, rotation);
        SetVehicleColours(colorPrimary, colorSecondary);

        Velocity = velocity;
        NumberPlate = numberPlate;
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

    public bool IsVehicleInBurnout()
    {
        return CryVNative.Native_Vehicle_IsVehicleInBurnout(CryVNative.Plugin, Handle);
    }

    public void SetVehicleBurnout(bool toggle)
    {
        CryVNative.Native_Vehicle_SetVehicleBurnout(CryVNative.Plugin, Handle, toggle);
    }

    public void GetVehicleColours(out int primary, out int secondary)
    {
        primary = 0;
        secondary = 0;

        CryVNative.Native_Vehicle_GetVehicleColours(CryVNative.Plugin, Handle, ref primary, ref secondary);
    }

    public void SetVehicleColours(int primary, int secondary)
    {
        CryVNative.Native_Vehicle_SetVehicleColours(CryVNative.Plugin, Handle, primary, secondary);
    }

    public bool IsVehicleAConvertible()
    {
        return CryVNative.Native_Vehicle_IsVehicleAConvertible(CryVNative.Plugin, Handle, false);
    }

    public int GetConvertibleRoofState()
    {
        if (IsVehicleAConvertible() == false)
        {
            return -1;
        }

        return CryVNative.Native_Vehicle_GetConvertibleRoofState(CryVNative.Plugin, Handle);
    }

    public void LowerConvertibleRoof(bool instant)
    {
        if (IsVehicleAConvertible() == false)
        {
            return;
        }

        CryVNative.Native_Vehicle_LowerConvertibleRoof(CryVNative.Plugin, Handle, instant);
    }

    public void RaiseConvertibleRoof(bool instant)
    {
        if (IsVehicleAConvertible() == false)
        {
            return;
        }

        CryVNative.Native_Vehicle_RaiseConvertibleRoof(CryVNative.Plugin, Handle, instant);
    }

    public void Explode(bool isAudible, bool isInvisible)
    {
        CryVNative.Native_Vehicle_ExplodeVehicle(CryVNative.Plugin, Handle, isAudible, isInvisible);
    }

    public bool IsVehicleSeatFree(VehicleSeat seat)
    {
        return CryVNative.Native_Vehicle_IsVehicleSeatFree(CryVNative.Plugin, Handle, (int) seat);
    }

    public Vector3 GetWorldPositionOfBone(int boneIndex)
    {
        return StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Entity_GetWorldPositionOfEntityBone(CryVNative.Plugin, Handle, boneIndex));
    }

    public Vehicle? GetTrailer()
    {
        var vehicle = 0;

        CryVNative.Native_Vehicle_GetVehicleTrailerVehicle(CryVNative.Plugin, Handle, ref vehicle);

        if (vehicle == 0)
        {
            return null;
        }

        return new Vehicle(vehicle);
    }

    public void AttachToTrailer(Vehicle trailer)
    {
        CryVNative.Native_Vehicle_AttachVehicleToTrailer(CryVNative.Plugin, Handle, trailer.Handle, 10.0f);
    }

    public void DetachFromTrailer()
    {
        CryVNative.Native_Vehicle_DetachVehicleFromTrailer(CryVNative.Plugin, Handle);
    }

    public bool IsThisModelABike()
    {
        return CryVNative.Native_Vehicle_IsThisModelABike(CryVNative.Plugin, Model);
    }

    public void SetTrailerLegsRaised()
    {
        CryVNative.Native_Vehicle__0x95CF53B3D687F9FA(CryVNative.Plugin, Handle);
    }

    public void SetTrailerLegsLowered()
    {
        CryVNative.Native_Vehicle__0x878C75C09FBDB942(CryVNative.Plugin, Handle);
    }

    public int GetBoneIndexByName(string boneName)
    {
        using var converter = new StringConverter();
        var bonePointer = converter.StringToPointer(boneName);

        return CryVNative.Native_Entity_GetEntityBoneIndexByName(CryVNative.Plugin, Handle, bonePointer);
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
        DirtLevel = 0.0f;

        Streaming.UnloadModel(model);
    }

}
