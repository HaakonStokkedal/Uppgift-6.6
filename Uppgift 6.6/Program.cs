using System.Diagnostics.SymbolStore;

namespace Uppgift_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening:");
            string svar = Console.ReadLine();
            StoraSmå(svar);
            Console.ReadKey();
        }

        static void StoraSmå(string s)
        {
            string[] strings = s.Split(' ');

            for (int i = 0; i < strings.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(strings[i].ToLower());
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(strings[i].ToUpper());
                    Console.Write(" ");
                }
            }
        }
    }
}