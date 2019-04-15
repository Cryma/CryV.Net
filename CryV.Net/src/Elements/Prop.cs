using System.Numerics;
using CryV.Net.Native;

namespace CryV.Net.Elements
{
    public class Prop : Entity
    {
        public Prop(int handle) : base(handle)
        {
        }

        public Prop(uint model, Vector3 position) : base(0)
        {

        }

        private void CreateProp(uint model, Vector3 position)
        {
            Streaming.LoadModel(model);

            Handle = CryVNative.Native_Prop_CreateObject(CryVNative.Plugin, model, position.X, position.Y, position.Z, true, true, false);

            Streaming.UnloadModel(model);
        }

    }
}
