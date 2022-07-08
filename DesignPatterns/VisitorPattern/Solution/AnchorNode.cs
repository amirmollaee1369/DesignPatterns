using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Solution
{
    public class AnchorNode : IHtmlNode
    {
        public void execute(IOperation operation)
        {
            operation.apply(this);
        }
    }
}
