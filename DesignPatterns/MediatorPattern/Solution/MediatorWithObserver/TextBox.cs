using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public class TextBox : UIControl
    {
        private string content;
        public string GetContent()
        {
            return content;
        }

        public void SetContent(string value)
        {
            content = value;
            notifyEventHandle();
        }
    }
}
