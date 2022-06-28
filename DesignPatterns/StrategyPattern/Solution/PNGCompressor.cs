using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Solution
{
    public class PNGCompressor : ICompressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
