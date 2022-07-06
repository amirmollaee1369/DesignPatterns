using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Solution
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool doHandle(HttpRequest httpRequest)
        {
            var isValid = (httpRequest.userName == "admin" &&
                httpRequest.password == "123");

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
