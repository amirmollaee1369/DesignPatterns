using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MementoPattern
{
    public class History
    {
        public List<EditorState> states { get; set; } = new List<EditorState>();

        public void push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState pop()
        {
            var state= states[states.Count - 1];
            states.RemoveAt(states.Count - 1);
            return state;
        }
    }
}
