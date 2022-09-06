using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesCrypto;


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

                Console.WriteLine("RSA:");
                ClassRSA classRSA = new ClassRSA();
               
                try
                {
                    classRSA.LoadPublicKeyToFile("pub");
                    classRSA.LoadPrivateKeyToFile("pri");
                }
                catch { classRSA.GenerateKeys(); }


                L2 = classRSA.EnCrypt(L1);                 
                Console.WriteLine(L2);
                L1 = classRSA.DeCrypt(L2);
                Console.WriteLine(L1);
                classRSA.SavePrivateKeyToFile("pri");
                classRSA.SavePublicKeyToFile("pub");
                Console.WriteLine();

                Console.WriteLine("Caesar");
                L2 = ClassCaesar.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassCaesar.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("Reserver");
                L2 = ClassReserve.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassReserve.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("ClassRijndael");
                L2 = ClassRijndael.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassRijndael.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("Sha512");
                L2 = ClassSHA512.EnCrypt(L1);
                Console.WriteLine(L2);
                Console.WriteLine();

                Console.WriteLine("Transpotion");
                L2 = ClassTransposition.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassTransposition.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("ClassSHA256");
                L2 = ClassSHA256.EnCrypt(L1);
                Console.WriteLine(L2);
                Console.WriteLine();

                Console.WriteLine("ClassAES");
                L2 = ClassAES.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassAES.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("ClassDES");
                L2 = ClassDES.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassDES.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("ClassRC2");
                L2 = ClassRC2.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassRC2.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("ClassTripleDES");
                L2 = ClassTripleDES.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassTripleDES.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();


                Console.WriteLine("ClassPair");
                L2 = ClassPair.EnCrypt(L1);
                Console.WriteLine(L2);
                L1 = ClassPair.DeCrypt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();

                Console.WriteLine("ClassSalt");
                L2 = ClassSalt.AddSalt(L1);
                Console.WriteLine(L2);
                L1 = ClassSalt.DeleteSalt(L2);
                Console.WriteLine(L1);
                Console.WriteLine();



            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }
            finally { Console.ReadKey(); }
        }
    }
}
