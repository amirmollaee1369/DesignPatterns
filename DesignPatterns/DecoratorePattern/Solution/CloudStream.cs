using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorePattern.Solution
{
    public class CloudStream : IStream
    {
        public void write(string data)
        {
            Console.WriteLine($"Storing "+data);
        }
    }
}
