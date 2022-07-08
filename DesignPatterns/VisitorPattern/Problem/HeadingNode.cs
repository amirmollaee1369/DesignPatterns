using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Problem
{
    public class HeadingNode : IHtmlNode
    {
        public void highlight()
        {
            Console.WriteLine("highlight-heading");
        }
    }
}
