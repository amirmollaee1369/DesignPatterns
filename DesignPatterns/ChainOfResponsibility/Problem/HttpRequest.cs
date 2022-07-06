using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Problem
{
    public class HttpRequest
    {
        public string userName { get; set; }
        public string password { get; set; }
        public HttpRequest(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
