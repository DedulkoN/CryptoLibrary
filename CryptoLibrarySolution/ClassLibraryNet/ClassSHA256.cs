﻿using System.Text;
using System.Security.Cryptography;

namespace ClasesCrypto
{
    /// <summary>
    /// класс хеширования по алгоритму SHA256
    /// </summary>
    public class ClassSHA256
    {

        /// <summary>
        /// Хеширование
        /// </summary>
        /// <param name="Line">Строка</param>
        /// <returns>хэш строки</returns>
        public static string EnCrypt(string Line)
        {
            
            byte[] bytes = Encoding.UTF8.GetBytes(Line);
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedInputBytes = hash.ComputeHash(bytes);
                StringBuilder hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }

        }

    }
}
