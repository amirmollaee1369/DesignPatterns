using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Problem
{
    public class WebServer
    {
        public void handle(HttpRequest httpRequest)
        {
            //Authentication
            var authenticator = new Authenticator();
            authenticator.authenticate(httpRequest);//Depend
            //Compress
            var compressor = new Compressor();
            compressor.compress(httpRequest);//Depend
            //Loging
            var logger = new Logger();
            logger.log(httpRequest);//Depend
        }
    }
}
