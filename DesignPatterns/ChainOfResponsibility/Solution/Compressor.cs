using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Solution
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}
