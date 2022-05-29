using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Problem
{
    public abstract class RemoteControl
    {
        public abstract void turnOn();
        public abstract void turnOff();
    }
}
