using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.Problem
{
    public class Canvas
    {
        public ToolType currentTool { get; set; }
        public void mouseDown()
        {
            if (currentTool == ToolType.SELECTION)
                Console.WriteLine("Selection icon");
            else if (currentTool == ToolType.BRUSH)
                Console.WriteLine("Brush icon");
            else if (currentTool == ToolType.ERASER)
                Console.WriteLine("Eraser icon");
        }

        public void mouseUp()
        {
            if (currentTool == ToolType.SELECTION)
                Console.WriteLine("Draw dashed rectangle");
            else if (currentTool == ToolType.BRUSH)
                Console.WriteLine("Draw a line");
            else if (currentTool == ToolType.ERASER)
                Console.WriteLine("Erase somthings");
        }
    }
}
