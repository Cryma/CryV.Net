using System.Numerics;
using Autofac;
using CryV.Net.Elements;
using CryV.Net.Helpers;
using CryV.Net.Shared.Common.Interfaces;
using CryV.Net.Shared.Common.Payloads;
using CryV.Net.Shared.Events.Types;

namespace CryV.Net.Client.LocalPlayer
{
    public class LocalPlayer : IStartable
    {

        private readonly IEventHandler _eventHandler;

        public LocalPlayer(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }

        public void Start()
        {
            _eventHandler.Subscribe<NetworkEvent<BootstrapPayload>>(OnBootstrap);
        }

        private void OnBootstrap(NetworkEvent<BootstrapPayload> obj)
        {
            var payload = obj.Payload;

            ThreadHelper.Run(() =>
            {
                var rotation = Elements.LocalPlayer.Character.Rotation;

                Elements.LocalPlayer.Character.Position = payload.StartPosition;
                Elements.LocalPlayer.Model = payload.StartModel;
                Elements.LocalPlayer.Character.Rotation = new Vector3(rotation.X, rotation.Y, payload.StartHeading);
            });
        }
    }
}
