using System.Text;


namespace ClasesCrypto
{
    /// <summary>
    /// Реализация матричного метода
    /// </summary>
    public class ClassMatrix
    {
        /// <summary>
        /// Алфавит
        /// </summary>
        private static readonly string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz0123456789.,;: АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Матрица символов
        /// </summary>
        private static char[,] AlphabetMatrix;
        /// <summary>
        /// Ключ шифрования
        /// </summary>
        private static string key = "AmЩсCdJЫsdукЫВsdd9ыw34 .";

        /// <summary>
        /// Конструктор, создание матрицы символов
        /// </summary>
        static ClassMatrix()
        {
            AlphabetMatrix = new char[Alphabet.Length, Alphabet.Length];

            for(int i = 0; i < Alphabet.Length; i++)
            {
                int k = 0;
                for(int j = i; j<Alphabet.Length;j++)
                {
                    AlphabetMatrix[i,k] = Alphabet[j];
                    k++;
                }
                for (int j = 0; j < i; j++)
                {
                    AlphabetMatrix[i, k] = Alphabet[j];
                    k++;
                }

            }
        }

        /// <summary>
        /// Шифрование
        /// </summary>
        /// <param name="Line">Входная строка</param>
        /// <returns>Зашифрованнная строка</returns>
        public static string EnCrypt(string Line)
        {
            StringBuilder result = new StringBuilder();


            int k = 0;
            for (int l = 0; l < Line.Length; l++)
            {
                int i, j;
                for (i = 0; i < Alphabet.Length; i++)
                {
                    if (AlphabetMatrix[i, 0] == Line[l])
                    { break; }
                }
                for (j = 0; j < Alphabet.Length; j++)
                {
                    if (AlphabetMatrix[0, j] == key[k])
                    { break; }
                }

                result.Append(AlphabetMatrix[i, j]);
                k++;
                if (k == key.Length) k = 0;
            }

            return result.ToString();
        }

        /// <summary>
        /// Дешифрование
        /// </summary>
        /// <param name="CryptoLine">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public static string DeCrypt(string Line)
        {
            StringBuilder result = new StringBuilder();


            int k = 0;
            for (int l = 0; l < Line.Length; l++)
            {
                int i, j;
                
                for (j = 0; j < Alphabet.Length; j++)
                {
                    if (AlphabetMatrix[0, j] == key[k])
                    { break; }
                }

                for (i = 0; i < Alphabet.Length; i++)
                {
                    if (AlphabetMatrix[i, j] == Line[l])
                    { break; }
                }

                result.Append(AlphabetMatrix[i, 0]);
                k++;
                if (k == key.Length) k = 0;
            }

            return result.ToString();
        }

    }
}
