using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.editor
{
    public class History
    {
        private List<IUndoableCommand> undoableCommands;

        public History()
        {
            this.undoableCommands = new List<IUndoableCommand>();
        }

        public void push(IUndoableCommand undoableCommand) { 
            undoableCommands.Add(undoableCommand);
        }

        public IUndoableCommand pop() { 
            var lastIndex=undoableCommands.Count-1;
            var undoableCommand=undoableCommands[lastIndex];
            undoableCommands.RemoveAt(lastIndex);
            return undoableCommand;
        }

        public int size()
        {
            return undoableCommands.Count;
        }
    }
}
