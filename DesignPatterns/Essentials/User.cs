using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Essentials
{
    public class User
    {
        public string Name { get; set; }

        //Coupling bcz if i add another prop like age in ctor every place that use this class must be change : solution is use interface
        public User(string name)
        {
            Name = name;
        }
        public void SayHello()
        {
            Console.WriteLine($"Hi {Name}");
        }
    }
}
