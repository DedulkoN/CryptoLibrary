using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClasesCrypto
{
    /// <summary>
    /// Шифрование простой престановкой
    /// </summary>
    public static class ClassTransposition 
    {
        /// <summary>
        /// Дешифрование 
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public static string DeCrypt(string CryptoLine)
        {
            StringBuilder rezult = new StringBuilder();
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


        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="Line">Изначальная строка</param>
        /// <returns>Шифрованная трока</returns>
        public static string EnCrypt(string Line)
        {
            StringBuilder rezult = new StringBuilder();
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
