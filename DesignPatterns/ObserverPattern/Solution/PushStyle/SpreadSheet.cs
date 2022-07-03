using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution.PushStyle
{
    public class SpreadSheet : IObserver
    {
        public void update(int value)
        {
            Console.WriteLine($"SpreadSheat got nitified.{value}");
        }
    }
}
