using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoLibrary
{
    internal class ClassCaesar
    {
        private readonly string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz0123456789.,;: АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Шифрование алгоритмом Цезаря (смещением)
        /// </summary>
        /// <param name="Line">Входная строка</param>
        /// <returns>Зашифрованнная строка</returns>
        public string EnCrypt(string Line)
        {
            StringBuilder result = new();

            for(int i = 0; i<Line.Length; i++)
            {
                int index = 0;
                for (; Line[i] != Alphabet[index]; index++) ;     
               result.Append(Alphabet[(i + index) % Alphabet.Length]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Дешифрование алгоритма Цезаря
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public string DeCrypt(string CryptoLine)
        {
            StringBuilder result = new();

            for (int i = 0; i < CryptoLine.Length; i++)
            {
                int index = 0;
                for (; CryptoLine[i] != Alphabet[index]; index++) ;

                result.Append(Alphabet[(index - i + Alphabet.Length) % Alphabet.Length]);
            }

            return result.ToString();
        }


    }
}
