﻿using System.Text;


namespace ClasesCrypto
{
    /// <summary>
    /// Реализация алгоритма Цезаря, вариант Вижинера
    /// </summary>
    public static class ClassCaesar
    {
        /// <summary>
        /// Алфавит
        /// </summary>
        private static readonly string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz0123456789.,;:+-*/ АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Шифрование алгоритмом Цезаря (смещением), вариант Вижинера
        /// </summary>
        /// <param name="Line">Входная строка</param>
        /// <returns>Зашифрованнная строка</returns>
        public static string EnCrypt(string Line)
        {
            StringBuilder result = new StringBuilder();

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
        public static string DeCrypt(string CryptoLine)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < CryptoLine.Length; i++)
            {
                int index = 0;
                for (; CryptoLine[i] != Alphabet[index]; index++);

                result.Append(Alphabet[(index - i + Alphabet.Length) % Alphabet.Length]);
            }

            return result.ToString();
        }


    }
}
