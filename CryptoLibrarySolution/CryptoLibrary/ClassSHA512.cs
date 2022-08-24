using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CryptoLibrary
{

    /// <summary>
    /// класс хеширования по алгоритму SHA512
    /// </summary>
    internal class ClassSHA512 : ICrypto
    {
        /// <summary>
        /// Дешифрование, генерирует исключение
        /// </summary>
        /// <param name="CryptoLine">Строка</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">Ошибка - дешифровать невозможно</exception>
        public string DeCrypt(string CryptoLine)
        {
            throw new NotImplementedException("Хэширование не дешифруется");
        }

        /// <summary>
        /// Хеширование
        /// </summary>
        /// <param name="Line">Строка</param>
        /// <returns>хэш строки</returns>
        public string EnCrypt(string Line)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(Line);
            using (SHA512 hash = SHA512.Create())
            {
                byte[] hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                StringBuilder hashedInputStringBuilder = new(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }

        }
    }
}
