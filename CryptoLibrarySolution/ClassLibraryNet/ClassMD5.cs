﻿using System.Text;
using System.Security.Cryptography;

namespace ClasesCrypto
{
    /// <summary>
    /// класс хеширования по алгоритму MD5
    /// </summary>
    public class ClassMD5
    {

        /// <summary>
        /// Хеширование
        /// </summary>
        /// <param name="Line">Строка</param>
        /// <returns>хэш строки</returns>
        public static string EnCrypt(string Line)
        {

            byte[] bytes = Encoding.UTF8.GetBytes(Line);
            using (MD5 hash = MD5.Create())
            {
                byte[] hashedInputBytes = hash.ComputeHash(bytes);
                StringBuilder hashedInputStringBuilder = new StringBuilder();
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }

        }
    }
}
