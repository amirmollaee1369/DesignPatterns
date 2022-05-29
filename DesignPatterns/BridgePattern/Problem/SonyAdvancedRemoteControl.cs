using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BridgePattern.Problem
{
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl
    {
        public override void setChannel(int number)
        {
            Console.WriteLine("Sony : setChannel");   
        }

        public override void turnOff()
        {
            Console.WriteLine("Sony : turnOff");
        }

        public override void turnOn()
        {
            Console.WriteLine("Sony : turnOn");
        }
    }
}
