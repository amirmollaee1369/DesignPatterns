using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorePattern.Problem
{
    public class CloudStream
    {
        public virtual void write(string data)
        {
            Console.WriteLine($"Storing " + data);
        }
    }
}
