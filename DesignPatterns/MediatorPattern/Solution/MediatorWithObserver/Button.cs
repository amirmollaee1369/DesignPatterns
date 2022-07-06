using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public class Button : UIControl
    {
        private bool isEnabled;

        public bool GetisEnabled()
        {
            return isEnabled;
        }

        public void SetisEnabled(bool value)
        {
            isEnabled = value;
            notifyEventHandle();
        }
    }
}
