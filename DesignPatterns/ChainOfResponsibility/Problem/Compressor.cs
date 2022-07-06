using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Problem
{
    public class Compressor
    {
        public void compress(HttpRequest request)
        {
            Console.WriteLine("Compress");
        }
    }
}
