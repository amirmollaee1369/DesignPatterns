using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorePattern.Problem
{
    public class CompressedCloudStream : CloudStream
    {
        public override void write(string data)
        {
            var compressedData = compresseData(data);

            base.write(compressedData); 
        }

        private string compresseData(string data)
        {
            return "!@#DFW@#!R%EFWERW";
        }
    }
}
