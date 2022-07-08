using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Problem
{
    public class AnchorNode : IHtmlNode
    {
        public void highlight()
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
