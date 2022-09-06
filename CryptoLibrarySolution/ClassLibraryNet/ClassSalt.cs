using System;
using System.Text;


namespace ClasesCrypto
{
    /// <summary>
    /// Класс добавления соли (допсимволов)
    /// </summary>
    public class ClassSalt
    {
        /// <summary>
        /// Алфавит
        /// </summary>
        private static readonly string Alphabet = " QWERTYUIOPASDFGHJKLZXCVBNM.,;:ЁЙЦУКЕНГШЩЗХЪЭЖДЛОРПАВЫФЯЧСМИТЬБЮюбьтимсчяфывапролджэъхзщшгнекуцйёmnbvcxzlkjhgfdsapoiuytrewq0123456789";

        /// <summary>
        /// Добавить соль
        /// </summary>
        /// <param name="Line">изначальная строка</param>
        /// <returns>Результат-строка</returns>
        static public string AddSalt(string Line)
        {
            StringBuilder result = new StringBuilder();

            Random random = new Random();

            foreach (char c in Line)
            {
                result.Append(c);
                result.Append(Alphabet[random.Next(0,Alphabet.Length)]);
            }

            return result.ToString();

        }       

        /// <summary>
        /// Удаление соли из строки
        /// </summary>
        /// <param name="Line">Строка с солью</param>
        /// <returns>СТрока без соли</returns>
        static public string DeleteSalt(string Line)
        {
            StringBuilder result = new StringBuilder();

            for(int i = 0; i<Line.Length;i+=2)
                result.Append(Line[i]);

            return result.ToString();
        }



    }
}
