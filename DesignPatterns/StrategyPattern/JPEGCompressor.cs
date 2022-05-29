using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class JPEGCompressor : ICompressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
