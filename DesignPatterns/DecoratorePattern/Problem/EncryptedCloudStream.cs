using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorePattern.Problem
{
    public class EncryptedCloudStream : CloudStream
    {
        public override void write(string data)
        {
            var encrypted = encrypteData(data);

            base.write(encrypted); 
        }

        private string encrypteData(string data)
        {
            return "!@#DFW@#!R%EFWERW";
        }
    }
}
