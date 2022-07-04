using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution
{
    public class ListBox : UIControl
    {        
        public ListBox(DialogBox owner) : base(owner)
        {
        }
        private string selection;
        public string GetSelection()
        {
            return selection;
        }

        public void SetSelection(string value)
        {
            selection = value;
            owner.changed(this);
        }
    }
}
