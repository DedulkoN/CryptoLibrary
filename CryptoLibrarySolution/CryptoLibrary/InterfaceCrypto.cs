using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    internal interface ICrypto
    {
        public string EnCrypt(string Line);
        public string DeCrypt( string CryptoLine);
  
    }
}
