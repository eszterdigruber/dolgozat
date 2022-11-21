using System.Globalization;

namespace dolgozat
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat:");
            Console.Write("maximálisan megengedett sebbeség (kmph): ");
            string sebesseg = Console.ReadLine();
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat:");
            Console.Write("karakterlánc: ");
            string karakterlanc = Console.ReadLine();
            int szam = rnd.Next(0, 9);
            Console.WriteLine($"a generált szám: {szam}");
            if (szam % 2 == 0)
            {
                for (int i = 0; i < szam; i++)
                {
                    Console.WriteLine($"{karakterlanc}");
                }
            }
            else
            {
                for (int i = 0; i < szam; i++)
                {
                    Console.WriteLine($"{karakterlanc} ");
                }
            }
        }
    }
}