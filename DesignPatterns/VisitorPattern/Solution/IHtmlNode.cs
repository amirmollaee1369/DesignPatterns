using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern.Solution
{
    public interface IHtmlNode
    {
        void execute(IOperation operation);
    }
}
