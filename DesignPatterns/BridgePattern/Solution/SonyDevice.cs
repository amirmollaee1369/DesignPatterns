using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Solution
{
    public class SonyDevice : IDevice
    {
        public void setChannel(int number)
        {
            Console.WriteLine("Sony : setChannel");
        }

        public void turnOff()
        {
            Console.WriteLine("Sony : turnOff");
        }

        public void turnOn()
        {
            Console.WriteLine("Sony : turnOn");
        }
    }
}
