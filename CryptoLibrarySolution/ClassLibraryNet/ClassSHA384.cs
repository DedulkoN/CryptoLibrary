using System.Text;
using System.Security.Cryptography;

namespace ClasesCrypto
{
    /// <summary>
    /// класс хеширования по алгоритму SHA384
    /// </summary>
    public class ClassSHA384
    {

        /// <summary>
        /// Хеширование
        /// </summary>
        /// <param name="Line">Строка</param>
        /// <returns>хэш строки</returns>
        public static string EnCrypt(string Line)
        {

            byte[] bytes = Encoding.UTF8.GetBytes(Line);
            using (SHA384 hash = SHA384.Create())
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
