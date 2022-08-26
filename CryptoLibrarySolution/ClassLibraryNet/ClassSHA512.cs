using System.Text;
using System.Security.Cryptography;

namespace ClasesCrypto
{

    /// <summary>
    /// класс хеширования по алгоритму SHA512
    /// </summary>
    public static class ClassSHA512
    {
        /// <summary>
        /// Хеширование
        /// </summary>
        /// <param name="Line">Строка</param>
        /// <returns>хэш строки</returns>
        public static string EnCrypt(string Line)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(Line);
            using (SHA512 hash = SHA512.Create())
            {
                byte[] hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                StringBuilder hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }

        }
    }
}
