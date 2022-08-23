using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    /// <summary>
    /// Реализация алгоритма обратной записи
    /// </summary>
    internal class ClassReserve:ICrypto
    {
        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="Line">Изначальная строка</param>
        /// <returns>Шифрованная трока</returns>
        public string EnCrypt(string Line)
        {

            StringBuilder result = new();
            for(int i = Line.Length-1; i>=0;i--)
                result.Append(Line[i]);

            return result.ToString();
        }

        /// <summary>
        /// Дешифрование 
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public string DeCrypt(string CryptoLine)
        {
            return EnCrypt(CryptoLine);
        }
    }
}
