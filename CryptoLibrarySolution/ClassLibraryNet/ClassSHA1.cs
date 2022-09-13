using System.Text;
using System.Security.Cryptography;

namespace ClasesCrypto
{
    /// <summary>
    /// класс хеширования по алгоритму SHA1
    /// </summary>
    public class ClassSHA1
    {
        /// <summary>
        /// Хеширование
        /// </summary>
        /// <param name="Line">Строка</param>
        /// <returns>хэш строки</returns>
        public static string EnCrypt(string Line)
        {

            byte[] bytes = Encoding.UTF8.GetBytes(Line);
            using (SHA1 hash = SHA1.Create())
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
