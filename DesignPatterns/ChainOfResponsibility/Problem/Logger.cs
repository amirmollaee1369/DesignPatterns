using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Problem
{
    public class Logger
    {
        public void log(HttpRequest httpRequest)
        {
            Console.WriteLine("Log");
        }
    }
}
