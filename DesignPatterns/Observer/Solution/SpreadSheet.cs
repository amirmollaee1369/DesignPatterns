using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution
{
    public class SpreadSheet : IObserver
    {
        public void update()
        {
            Console.WriteLine("SpreadSheat got nitified.");
        }
    }
}
