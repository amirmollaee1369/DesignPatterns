using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Problem
{
    public class Authenticator
    {
        public bool authenticate(HttpRequest httpRequest)
        {
            var isValid=(httpRequest.userName == "admin" &&
                httpRequest.password == "123");

            Console.WriteLine("Authentication");

            return isValid;
        }
    }
}
