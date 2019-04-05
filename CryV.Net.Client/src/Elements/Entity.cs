using System.Numerics;
using CryV.Net.Client.Helpers;
using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public abstract class Entity
    {

        public int Handle { get; protected set; }

        public Vector3 Position
        {
            get => StructConverter.PointerToStruct<Vector3>(CryVNative.Native_Entity_GetEntityPosition(CryVNative.Plugin, Handle));
            set => CryVNative.Native_Entity_SetEntityPosition(CryVNative.Plugin, Handle, value.X, value.Y, value.Z);
        }

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
            CryVNative.Native_Entity_SetEntityAsNoLongerNeeded(CryVNative.Plugin, Handle);
        }

        public void SetAsMissionEntity(bool p1 = false, bool p2 = true)
        {
            CryVNative.Native_Entity_SetEntityAsMissionEntity(CryVNative.Plugin, Handle, p1, p2);
        }

        public void Delete()
        {
            CryVNative.Native_Entity_DeleteEntity(CryVNative.Plugin, Handle);

            Handle = 0;
        }

    }
}
