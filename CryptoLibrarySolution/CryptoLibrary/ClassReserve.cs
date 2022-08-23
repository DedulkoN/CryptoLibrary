using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    internal class ClassReserve:ICrypto
    {
        public string EnCrypt(string Line)
        {

            StringBuilder result = new();
            for(int i =0; i<Line.Length;i++)
                result.Append(Line[i]);

            return result.ToString();
        }
        public string DeCrypt(string CryptoLine)
        {
            return EnCrypt(CryptoLine);
        }
    }
}
