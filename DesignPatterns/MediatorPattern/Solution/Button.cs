using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution
{
    public class Button : UIControl
    {
        public Button(DialogBox owner) : base(owner)
        {
        }

        private bool isEnabled;

        public bool GetisEnabled()
        {
            return isEnabled;
        }

        public void SetisEnabled(bool value)
        {
            isEnabled = value;
            owner.changed(this);
        }
    }
}
