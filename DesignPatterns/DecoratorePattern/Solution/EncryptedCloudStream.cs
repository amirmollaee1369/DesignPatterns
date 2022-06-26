using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorePattern.Solution
{
    public class EncryptedCloudStream : IStream
    {
        private IStream stream;
        public EncryptedCloudStream(IStream stream)
        {
           this.stream = stream;
        }

        public void write(string data)
        {
            var encrypted = encrypteData(data);

            stream.write(encrypted); 
        }

        private string encrypteData(string data)
        {
            return "!@#DFW@#!R%EFWERW";
        }
    }
}
