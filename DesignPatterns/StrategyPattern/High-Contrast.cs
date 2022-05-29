using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class High_Contrast : IFilter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Applying high-contrast filter");
        }
    }
}
