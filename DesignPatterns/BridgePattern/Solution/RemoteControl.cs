using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Solution
{
    public class RemoteControlBP
    {
        public IDevice device;

        public RemoteControlBP(IDevice device)
        {
            this.device = device;
        }

        public void turnOn()
        {
            device.turnOn();
        }
        public void turnOff()
        {
            device.turnOff();
        }
    }
}
