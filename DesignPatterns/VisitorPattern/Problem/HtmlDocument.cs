using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Problem
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes=new List<IHtmlNode>();
        
        public void add(IHtmlNode htmlNode)
        {
            nodes.Add(htmlNode);
        }

        public void highlight()
        {
            foreach (var node in nodes)
                node.highlight();
        }
    }
}
