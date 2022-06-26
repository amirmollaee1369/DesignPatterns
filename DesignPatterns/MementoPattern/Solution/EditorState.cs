using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MementoPattern.Solution
{
    public class EditorState
    {
        public string content;
        public EditorState(string content)
        {
            this.content = content;
        }

        public void restore(EditorState state)
        {
            content= state.content; 
        }
    }
}