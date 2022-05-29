using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Solution
{
    public class SamsungDevice : IDevice
    {
        public void setChannel(int number)
        {
            Console.WriteLine("Samsung : setChannel");
        }

        public void turnOff()
        {
            Console.WriteLine("Samsung : turnOff");
        }

        public void turnOn()
        {
            Console.WriteLine("Samsung : turnOn");
        }
    }
}
