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
            for (int i = cislo; i > 0; i = i - 1)
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
                if ((cislo > 3) && (cislo < 16))
                    {
                    break;
                }
            }
            while (true);

            double umocneno = PowerOfTwo(cislo);
            Console.WriteLine("Vaše čislo na druhou mocninu je: " + cislo);
            string hvezdicky = WriteStars(cislo);
            Console.WriteLine("Váš string pro zadané číslo vypadá takto:" + hvezdicky);

        }


    }
}
