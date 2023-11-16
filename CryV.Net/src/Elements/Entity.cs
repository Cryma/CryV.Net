using System.Numerics;
using CryV.Net.Helpers;
using CryV.Net.Native;

namespace CryV.Net.Elements;

public abstract class Entity
{

    public int Handle
    {
        get => _handle;
        protected set => _handle = value;
    }
    private int _handle;

    public int Health
    {
        get => CryVNative.Native_Entity_GetEntityHealth(CryVNative.Plugin, Handle);
        set => CryVNative.Native_Entity_SetEntityHealth(CryVNative.Plugin, Handle, value);
    }

    public Vector3 Position
    {
        get => StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Entity_GetEntityCoords(CryVNative.Plugin, Handle, true));
        set => CryVNative.Native_Entity_SetEntityCoordsNoOffset(CryVNative.Plugin, Handle, value.X, value.Y, value.Z, false, false, false);
    }

    public Vector3 Rotation
    {
        get => StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Entity_GetEntityRotation(CryVNative.Plugin, Handle, 2));
        set => CryVNative.Native_Entity_SetEntityRotation(CryVNative.Plugin, Handle, value.X, value.Y, value.Z, 2, true);
    }

    public Vector3 Velocity
    {
        get => StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Entity_GetEntityVelocity(CryVNative.Plugin, Handle));
        set => CryVNative.Native_Entity_SetEntityVelocity(CryVNative.Plugin, Handle, value.X, value.Y, value.Z);
    }

    public Vector3 Forward => StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Entity_GetEntityForwardVector(CryVNative.Plugin, Handle));

    protected Entity(int handle)
    {
        Handle = handle;
    }

    public bool DoesExist()
    {
        return IsValid() && CryVNative.Native_Entity_DoesEntityExist(CryVNative.Plugin, Handle);
    }

    public bool IsValid()
    {
        return Handle != 0;
    }

    public void SetAsNoLongerNeeded()
    {
        CryVNative.Native_Entity_SetEntityAsNoLongerNeeded(CryVNative.Plugin, ref _handle);
    }

    public void SetAsMissionEntity(bool p1 = false, bool p2 = true)
    {
        CryVNative.Native_Entity_SetEntityAsMissionEntity(CryVNative.Plugin, Handle, p1, p2);
    }

    public void SetEntityCollision(bool toggle, bool keepPhysics = false)
    {
        CryVNative.Native_Entity_SetEntityCollision(CryVNative.Plugin, Handle, toggle, keepPhysics);
    }

    public void SetEntityAlpha(int alphaLevel)
    {
        CryVNative.Native_Entity_SetEntityAlpha(CryVNative.Plugin, Handle, alphaLevel, 0);
    }

    public bool IsEntityPlayingAnim(string animDict, string animName, int taskFlag)
    {
        using var converter = new StringConverter();
        return CryVNative.Native_Entity_IsEntityPlayingAnim(CryVNative.Plugin, Handle, converter.StringToPointer(animDict), converter.StringToPointer(animName), taskFlag);
    }

    public bool IsEntityDead()
    {
        return CryVNative.Native_Entity_IsEntityDead(CryVNative.Plugin, Handle);
    }

    public void SetEntityInvincible(bool toggle)
    {
        CryVNative.Native_Entity_SetEntityInvincible(CryVNative.Plugin, Handle, toggle);
    }

    public Vector3 GetOffsetFromEntityGivenWorldCoords(Vector3 coordinates)
    {
        return StructConverter.PointerToStruct<Vector3>(
            CryVNative.Native_Entity_GetOffsetFromEntityGivenWorldCoords(CryVNative.Plugin, Handle, coordinates.X, coordinates.Y, coordinates.Z));
    }

    public float GetEntityPitch()
    {
        return CryVNative.Native_Entity_GetEntityPitch(CryVNative.Plugin, Handle);
    }

    public void Delete()
    {
        SetAsMissionEntity();

        CryVNative.Native_Entity_DeleteEntity(CryVNative.Plugin, ref _handle);

        EntityPool.RemoveEntity(Handle);

        Handle = 0;
    }

    protected bool Equals(Entity? other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }

        return _handle == other._handle;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((Entity) obj);
    }

    public override int GetHashCode()
    {
        return _handle; // TODO: Improve
    }

    public static bool operator ==(Entity left, Entity right)
    {
        return left?.Equals(right) ?? ReferenceEquals(right, null);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }

}
