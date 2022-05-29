using DesignPatterns.CommandPattern.fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Black and white");
        }
    }
}
