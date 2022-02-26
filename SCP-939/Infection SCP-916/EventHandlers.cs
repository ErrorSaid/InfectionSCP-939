using System;
using System.Linq;
using Exiled.Events.EventArgs;
using MEC;

namespace Infection_SCP_939
{
    public class EventHandlers
    {
        public void OnDying(DyingEventArgs ev)
        {
            Timing.CallDelayed(Main.singleton.Config.Delay, () =>
            {
                if (ev.Killer.Role == RoleType.Scp93953)
                {
                    ev.Target.SetRole(RoleType.Scp93953, lite: true);
                }
            });
        }
    }
}
