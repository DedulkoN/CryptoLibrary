using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    internal class ClassTransposition : ICrypto
    {
        public string DeCrypt(string CryptoLine)
        {
            StringBuilder rezult = new();
            for (int i = 0; i < CryptoLine.Length - 1; i += 2)
            {
                rezult.Append(CryptoLine[i + 1].ToString() + CryptoLine[i].ToString());
            }
            if (CryptoLine.Length % 2 == 1)
            {
                rezult.Append(CryptoLine[CryptoLine.Length - 1]);
            }

            return rezult.ToString();
        }

        public string EnCrypt(string Line)
        {
            StringBuilder rezult = new();
            for (int i = 0; i < Line.Length - 1; i += 2)
            {
                rezult.Append(Line[i + 1].ToString() + Line[i].ToString() );
            }
            if (Line.Length % 2 == 1)
            {
                rezult.Append(Line[Line.Length - 1]);
            }

            return rezult.ToString();
        }
    }
}
