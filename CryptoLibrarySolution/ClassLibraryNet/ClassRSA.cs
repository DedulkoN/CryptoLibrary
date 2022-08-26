using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace ClasesCrypto
{
    /// <summary>
    /// Шифрование алгоритмом RSA
    /// </summary>
    public class ClassRSA
    {
        RSAParameters privateKey;
        RSAParameters publicKey;

        /// <summary>
        /// Генерация ключей шифрования
        /// </summary>
        public void GenerateKeys()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            
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
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(publicKey);

            return System.Convert.ToBase64String(RSA.Encrypt(byteConverter.GetBytes(Line), false));
        }

        /// <summary>
        /// Дешифрование 
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public string DeCrypt(string CryptoLine)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(privateKey);
            return byteConverter.GetString(RSA.Decrypt(Convert.FromBase64String(CryptoLine), false));

        }

        /// <summary>
        /// Сохрание публичного ключа в файл xml
        /// </summary>
        /// <param name="FileName">Адрес и имя файла</param>
        public void SavePublicKeyToFile(string FileName)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(publicKey);
            string key = RSA.ToXmlString(false);

            FileStream f = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);
            sw.Write(key);            
            sw.Close();
            f.Close();
        }

        /// <summary>
        /// Сохрание приватного ключа в файл xml
        /// </summary>
        /// <param name="FileName">Адрес и имя файла</param>
        public void SavePrivateKeyToFile(string FileName)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(privateKey);
            string key = RSA.ToXmlString(true);

            FileStream f = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(f);
            sw.Write(key);
            sw.Close();
            f.Close();
        }


        /// <summary>
        /// Чтение публичного ключа из файла xml
        /// </summary>
        /// <param name="FileName">Адрес и имя файла</param>
        public void LoadPublicKeyToFile(string FileName)
        {
            string key;
            FileStream f = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(f);
            key= sw.ReadToEnd();
            sw.Close();
            f.Close();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(key);
            publicKey = RSA.ExportParameters(false);
        }

        /// <summary>
        /// Чтение приватного ключа из файла xml
        /// </summary>
        /// <param name="FileName">Адрес и имя файла</param>
        public void LoadPrivateKeyToFile(string FileName)
        {
            string key;
            FileStream f = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(f);
            key = sw.ReadToEnd();
            sw.Close();
            f.Close();
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(key);
            privateKey = RSA.ExportParameters(true);
        }

        /// <summary>
        /// Получение публичного ключа
        /// </summary>
        /// <returns>Строка в xml формате</returns>
        public string GetPublicKeyToXmlString()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(publicKey);
            return RSA.ToXmlString(false);
        }

        /// <summary>
        /// Получение приватного ключа
        /// </summary>
        /// <returns>Строка в xml формате</returns>
        public string GetPrivateKeyToXmlString()
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.ImportParameters(privateKey);
            return RSA.ToXmlString(true);
        }

        /// <summary>
        /// Установить открытый ключ
        /// </summary>
        /// <param name="xmlString">Ключ в формате XML-строки</param>
        public void SetPublicKeyFromXmlString(string xmlString)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(xmlString);
            publicKey = RSA.ExportParameters(false);
        }

        /// <summary>
        /// Установить закрытый ключ
        /// </summary>
        /// <param name="xmlString">Ключ в формате XML-строки</param>
        public void SetPrivateKeyFromXmlString(string xmlString)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            RSA.FromXmlString(xmlString);
            privateKey = RSA.ExportParameters(true);
        }


    }
}
