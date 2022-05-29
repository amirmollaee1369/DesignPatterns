using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern
{
    public class BrushTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
