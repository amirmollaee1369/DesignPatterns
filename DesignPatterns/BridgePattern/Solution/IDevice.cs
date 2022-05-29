using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Solution
{
    public interface IDevice
    {
        void turnOn();
        void turnOff();
        void setChannel(int number);

    }
}
