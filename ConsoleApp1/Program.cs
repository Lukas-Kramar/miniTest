using System;

namespace ConsoleApp1
{
    class Program
    {
        static double PowerOfTwo(double parametr)
        {
            double vysledek = Math.Pow(0, parametr);
            return vysledek;
        }

        static string WriteStars(int cislo)
        {
            string vysledek = "";
            for (int i = cislo; i >0; i = i-1)
            {
                vysledek += "*";
            }
            return vysledek;
        }
        static void Main(string[] args)
        {
            int cislo;
            bool zkouska;
            int vysledek;
            do
            {
                Console.Write("Zadejte prosím číslo od 3 do 15 včetně: ");
                string vstup = Console.ReadLine();
                zkouska = Int32.TryParse(vstup, out cislo);
                if (zkouska == true)
                {
                    break;
                }
            }
            while ((true) && (cislo > 3) && (cislo < 16));
            Console.WriteLine("Hello World!");
        }
    }
}
