using System;
using System.Linq;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Infection_SCP_939
{
    public class Config : IConfig
    {
        [Description("is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("how many seconds do you want for it to turn into scp-916")]
        public float Delay { get; set; } = 4f;  
    }
}
