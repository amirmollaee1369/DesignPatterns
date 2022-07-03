using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution.PushStyle
{
    internal class Chart : IObserver
    {
        public void update(int value)
        {
            Console.WriteLine($"Chart got updated{value}");
        }
    }
}
