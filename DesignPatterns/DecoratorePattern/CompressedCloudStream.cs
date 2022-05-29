using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorePattern
{
    public class CompressedCloudStream : IStream
    {
        private IStream stream;
        public CompressedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void write(string data)
        {
            var compressedData = compresseData(data);

            stream.write(compressedData); 
        }

        private string compresseData(string data)
        {
            return "!@#DFW@#!R%EFWERW";
        }
    }
}
