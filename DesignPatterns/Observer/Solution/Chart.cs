using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution
{
    internal class Chart : IObserver
    {
        public void update()
        {
            Console.WriteLine("Chart got updated");
        }
    }
}
