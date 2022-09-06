using System.Text;


namespace ClasesCrypto
{
    /// <summary>
    /// Парное шифрование
    /// </summary>
    public class ClassPair
    {
        /// <summary>
        /// Изначальный алфавит
        /// </summary>
        private static readonly string Alphabet1 = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz0123456789.,;: АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Алфавить для замены
        /// </summary>
        private static readonly string Alphabet2 = " QWERTYUIOPASDFGHJKLZXCVBNM.,;:ЁЙЦУКЕНГШЩЗХЪЭЖДЛОРПАВЫФЯЧСМИТЬБЮюбьтимсчяфывапролджэъхзщшгнекуцйёmnbvcxzlkjhgfdsapoiuytrewq0123456789";

        /// <summary>
        /// Зашифровать строку
        /// </summary>
        /// <param name="Line">Строка для шифрования</param>
        /// <returns>Зашифрованная строка</returns>
        public static string EnCrypt(string Line)
        {
            StringBuilder result = new StringBuilder();

            for(int i =0; i<Line.Length;i++)
            {
                int nChar = 0;
                for (int j = 0; j < Alphabet1.Length; j++)
                    if(Alphabet1[j] == Line[i]) 
                    { 
                        nChar = j; 
                        break; 
                    }
                result.Append(Alphabet2[nChar]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Расфишровать строку
        /// </summary>
        /// <param name="Line">Шифрованная строка</param>
        /// <returns>Расшифрованная строка</returns>
        public static string DeCrypt(string Line)
        {            
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Line.Length; i++)
            {
                int nChar = 0;
                for (int j = 0; j < Alphabet2.Length; j++)
                    if (Alphabet2[j] == Line[i])
                    {
                        nChar = j;
                        break;
                    }
                result.Append(Alphabet1[nChar]);
            }

            return result.ToString();
        }


    }
}
