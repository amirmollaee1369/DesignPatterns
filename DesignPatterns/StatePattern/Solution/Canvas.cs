using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.Solution
{
    public class Canvas
    {
        private ITool currentTool;

        public Canvas(ITool currentTool)
        {
            this.currentTool = currentTool;
        }

        public void mouseDown()
        {
            currentTool.mouseDown();
        }

        public void mouseUp()
        {
            currentTool.mouseUp();
        }
    }
}
