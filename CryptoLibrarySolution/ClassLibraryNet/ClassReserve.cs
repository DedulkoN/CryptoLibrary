using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCrypto
{
    /// <summary>
    /// Реализация алгоритма обратной записи
    /// </summary>
    public static class ClassReserve
    {
        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="Line">Изначальная строка</param>
        /// <returns>Шифрованная трока</returns>
        public static string EnCrypt(string Line)
        {

            StringBuilder result =  new StringBuilder();
            for(int i = Line.Length-1; i>=0;i--)
                result.Append(Line[i]);

            return result.ToString();
        }

        /// <summary>
        /// Дешифрование 
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public static string DeCrypt(string CryptoLine)
        {
            return EnCrypt(CryptoLine);
        }
    }
}
