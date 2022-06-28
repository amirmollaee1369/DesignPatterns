using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Solution
{
    public class BlackAndWihteFilter : IFilter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
