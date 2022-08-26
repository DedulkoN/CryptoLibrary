using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ClasesCrypto
{
    public class ClassDES
    {

        /// <summary>
        /// ключ
        /// </summary>
        static private string password = "µ¼asda2349-dgna7yrw-0awekm ╩lkjdsf 54&#D☺♀→,♪";

        /// <summary>
        /// Смена ключа шифрования
        /// </summary>
        /// <param name="NewKey"></param>
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
            DES sa = DESCryptoServiceProvider.Create();
            ICryptoTransform ct = sa.CreateEncryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(8),
                new byte[8]);

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
            DES sa = DESCryptoServiceProvider.Create();
            ICryptoTransform ct = sa.CreateDecryptor(
                (new PasswordDeriveBytes(password, null)).GetBytes(8),
                new byte[8]);

            MemoryStream ms = new MemoryStream(Convert.FromBase64String(data));
            CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }


    }
}
