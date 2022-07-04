using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution
{
    public class TextBox : UIControl
    {
        public TextBox(DialogBox owner) : base(owner)
        {
        }

        private string content;
        public string GetContent()
        {
            return content;
        }

        public void SetContent(string value)
        {
            content = value;
            owner.changed(this);
        }
    }
}
