using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Solution
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest httpRequest)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}
