using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Solution
{
    public class AdvancedRemoteControlBP : RemoteControlBP
    {
        public AdvancedRemoteControlBP(IDevice device) : base(device)
        {
        }

        public void setChannel(int number)
        {
            device.setChannel(number);
        }
    }
}
