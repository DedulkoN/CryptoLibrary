using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryNet;


namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string L1, L2;
                Console.Write("Введите строку: ");
                 L1 = Console.ReadLine();
                ClassRSA classRSA = new ClassRSA();
                classRSA.GenerateKeys();
                classRSA.LoadPublicKeyToFile("pub");
                classRSA.LoadPrivateKeyToFile("pri");


               /* L2 = classRSA.EnCrypt(L1);
                 
                 Console.WriteLine(L2);

                 L1 = classRSA.DeCrypt(L2);
               */
                 Console.WriteLine(L1);

                classRSA.SavePrivatecKeyToFile("pri");
                classRSA.SavePublicKeyToFile("pub");



            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }
            finally { Console.ReadKey(); }
        }
    }
}
