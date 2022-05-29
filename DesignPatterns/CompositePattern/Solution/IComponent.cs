using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern.Solution
{
    public interface IComponent
    {
        public void Render();
        public void Move();
    }
}
