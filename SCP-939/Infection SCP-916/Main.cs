using System;
using System.Linq;
using Exiled.API.Features;

namespace Infection_SCP_939
{
    public class Main : Plugin<Config>
    {
        public static Main singleton;

        public override string Author { get; } = "! Said";

        public override string Name { get; } = "Infection_SCP_939";

        public override string Prefix { get; } = "Infection SCP-939";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(4, 0, 0);

        public EventHandlers _handlers;
        public override void OnEnabled()
        {
            _handlers = new EventHandlers();
            singleton = this;

            Exiled.Events.Handlers.Player.Dying += _handlers.OnDying;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Dying -= _handlers.OnDying;

            _handlers = null;
            singleton = null;
            base.OnDisabled();
        }
    }
}
