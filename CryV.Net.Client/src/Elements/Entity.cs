using CryV.Net.Client.Native;

namespace CryV.Net.Client.Elements
{
    public abstract class Entity
    {

        public int Handle { get; }

        protected Entity(int handle)
        {
            Handle = handle;
        }

        public bool DoesExist()
        {
            return CryVNative.Native_Entity_DoesEntityExist(CryVNative.Plugin, Handle);
        }

        public void SetAsNoLongerNeeded()
        {
            CryVNative.Native_Entity_SetEntityAsNoLongerNeeded(CryVNative.Plugin, Handle);
        }

        public void SetAsMissionEntity(bool p1 = false, bool p2 = true)
        {
            CryVNative.Native_Entity_SetEntityAsMissionEntity(CryVNative.Plugin, Handle, p1, p2);
        }

    }
}
