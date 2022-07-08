using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Solution
{
    public class PlainTextOperation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("plaintext-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("plaintext-anchor");
        }
    }
}
