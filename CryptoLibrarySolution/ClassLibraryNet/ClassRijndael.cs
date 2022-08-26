using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace ClasesCrypto
{
    /// <summary>
    /// Класс шифрования. Алгоритм - Rijndael
    /// немноги устаревший
    /// </summary>
    public static class ClassRijndael 
    {
        /// <summary>
        /// ключ
        /// </summary>
        static private string password = "µ¼asda2349-dgna7yrw-0awekm lkjdsf 54&#D☺♀→,♪";

        /// <summary>
        /// Смена ключа шифрования
        /// </summary>
        /// <param name="NewKey"></param>
        static public void SetKey(string NewKey)
        {
            password = NewKey;            
        }



        static private byte[] Encrypt(byte[] data)
        {
            SymmetricAlgorithm sa = Rijndael.Create();
            ICryptoTransform ct = sa.CreateEncryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);

            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();

            return ms.ToArray();
        }

        /// <summary>
        /// Зашифровать строку
        /// </summary>
        /// <param name="data">Строка, которую необходимо зашифровать</param>
        /// <returns>Зашифрованная строка</returns>
        public  static string EnCrypt(string data)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(data)));
        }

        private static byte[] Decrypt(byte[] data)
        {
            BinaryReader br = new BinaryReader(InternalDecrypt(data));
            return br.ReadBytes(data.Length);
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <param name="data">Шифрованная строка</param>
        /// <returns>Дешифрованная строка</returns>
        public  static string DeCrypt(string data)
        {
            CryptoStream cs = InternalDecrypt(Convert.FromBase64String(data));
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        static CryptoStream InternalDecrypt(byte[] data)
        {
            SymmetricAlgorithm sa = Rijndael.Create();            
            ICryptoTransform ct = sa.CreateDecryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(16),
                new byte[16]);

            MemoryStream ms = new MemoryStream(data);
            return new CryptoStream(ms, ct, CryptoStreamMode.Read);
        }


        /// <summary>
        /// Зашифровать строку
        /// </summary>
        /// <param name="data">Строка, которую необходимо зашифровать</param>
        ///  <param name="key">Ключ шифрования</param>
        /// <returns>Зашифрованная строка</returns>
        public static string EnCrypt(string data, string key)
        {
            Rijndael sa = Rijndael.Create();
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
        /// <param name="key">Ключ шифрования</param>
        /// <returns>Дешифрованная строка</returns>
        public static string DeCrypt(string data, string key)
        {
            Rijndael sa = Rijndael.Create();
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
