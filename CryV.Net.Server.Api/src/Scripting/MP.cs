using CryV.Net.Server.Api.Elements;
using CryV.Net.Server.Common.Interfaces.Api;

namespace CryV.Net.Server.Api.Scripting
{
    public static class MP
    {

        private static Script _script;

        public static IEvents Events => _script.Events;

        public static IPlayerPool PlayerPool => _script.PlayerPool;
        public static IVehiclePool VehiclePool => _script.VehiclePool;

        internal static void Setup(Script script)
        {
            _script = script;
        }

    }
}
