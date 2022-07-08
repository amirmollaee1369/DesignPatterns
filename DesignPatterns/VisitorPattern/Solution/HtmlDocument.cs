using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Solution
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes=new List<IHtmlNode>();
        
        public void add(IHtmlNode htmlNode)
        {
            nodes.Add(htmlNode);
        }

        public void execute(IOperation operation)
        {
            foreach(var node in nodes)
            {
                node.execute(operation);
            }
        }
    }
}
