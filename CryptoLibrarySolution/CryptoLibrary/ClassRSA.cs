using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CryptoLibrary
{
    internal class ClassRSA:ICrypto
    {
        RSAParameters privateKey;
        RSAParameters publicKey;

        public void GenerateKeys(int keySize = 32)
        {
            RSACryptoServiceProvider RSA = new()
            {
                KeySize = keySize
            };
            privateKey = RSA.ExportParameters(true);
            publicKey = RSA.ExportParameters(false);            
        }

        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="Line">Изначальная строка</param>
        /// <returns>Шифрованная трока</returns>
        public string EnCrypt(string Line)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(publicKey);
            return Convert.ToBase64String(RSA.Encrypt(Convert.FromBase64String(Line), false));
        }

        /// <summary>
        /// Дешифрование 
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public string DeCrypt(string CryptoLine)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(privateKey);
            return Convert.ToBase64String(RSA.Decrypt(Convert.FromBase64String(CryptoLine), false));

        }

        public void SavePublicKeyToFile(string FileName)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(publicKey);
            string key = RSA.ToXmlString(false);

            FileStream f = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);
            sw.Write(key);            
            sw.Close();
            f.Close();
        }

        public void SavePrivatecKeyToFile(string FileName)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(privateKey);
            string key = RSA.ToXmlString(true);

            FileStream f = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);
            sw.Write(key);
            sw.Close();
            f.Close();
        }
        public void LoadPublicKeyToFile(string FileName)
        {
            string key;
            FileStream f = new FileStream(FileName, FileMode.Append, FileAccess.Read);
            StreamReader sw = new StreamReader(f);
            key= sw.ReadToEnd();
            sw.Close();
            f.Close();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(key);
            publicKey = RSA.ExportParameters(false);
        }

        public void LoadPrivateKeyToFile(string FileName)
        {
            string key;
            FileStream f = new FileStream(FileName, FileMode.Append, FileAccess.Read);
            StreamReader sw = new StreamReader(f);
            key = sw.ReadToEnd();
            sw.Close();
            f.Close();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(key);
            privateKey = RSA.ExportParameters(true);
        }

    }
}
