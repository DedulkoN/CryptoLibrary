using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;


namespace ClasesCrypto
{    /// <summary>
     /// Класс шифрования. Алгоритм - AES 
     /// результат подозрительно похож на Rijndael
     /// </summary>
    public static class ClassAES
    {
        /// <summary>
        /// ключ
        /// </summary>
        static private string password = "µ¼asda2349-dgna7yrw-0awekm ╩lkjdsf 54&#D☺♀→,♪";

        /// <summary>
        /// Смена ключа шифрования
        /// </summary>
        /// <param name="NewKey">Новый ключ шифрования</param>
        static public void SetKey(string NewKey)
        {
            password = NewKey;
        }

        /// <summary>
        /// Зашифровать строку
        /// </summary>
        /// <param name="data">Строка, которую необходимо зашифровать</param>
        /// <returns>Зашифрованная строка</returns>
        public static string EnCrypt(string data)
        {
            return EnCrypt(data, password);
        }

        /// <summary>
        /// Зашифровать строку
        /// </summary>
        /// <param name="data">Строка, которую необходимо зашифровать</param>
        /// <param name="key">Ключ шифрования</param>
        /// <returns>Зашифрованная строка</returns>
        public static string EnCrypt(string data, string key)
        {
            Aes sa = AesManaged.Create();
            ICryptoTransform ct = sa.CreateEncryptor(
                (new PasswordDeriveBytes(key, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);

            cs.Write(Encoding.UTF8.GetBytes(data), 0, data.Length);
            cs.FlushFinalBlock();

            return Convert.ToBase64String(ms.ToArray());
        }



        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <param name="data">Шифрованная строка</param>
        /// <returns>Дешифрованная строка</returns>
        public static string DeCrypt(string data)
        {
            return DeCrypt(data, password);
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <param name="data">Шифрованная строка</param>
        /// <param name="key">Ключ шифрования</param>
        /// <returns>Дешифрованная строка</returns>
        public static string DeCrypt(string data, string key)
        {
            Aes sa = AesManaged.Create();
            ICryptoTransform ct = sa.CreateDecryptor(
                (new PasswordDeriveBytes(key, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream(Convert.FromBase64String(data));
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

    }
}
