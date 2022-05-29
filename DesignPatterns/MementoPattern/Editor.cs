using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MementoPattern
{
    public class Editor
    {
        public string content;

        public EditorState createState()
        {
            return new EditorState(content);
        }


    }
}
