using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Solution
{
    public class HighlightOpreation : IOperation
    {
        public void apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
