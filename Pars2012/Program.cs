using Pars2012.Properties;

namespace Pars2012
{
    internal class Program
    {
        static List<Versenyzo> versenyzok = new();
        static string eleresiUt = @"..\..\..\Resources\";
        static void Main()
        {
            F04();
            F05();
            F06();
            F09();
            F10();
            Console.ReadKey();
        }

        private static void F10()
        {
            using StreamWriter sw = new($"{eleresiUt}Dontos2012.txt");

            List<Versenyzo> dontobeJutottak = versenyzok.OrderByDescending(versenyzo => versenyzo.Eredmeny).Take(12).ToList();

            sw.WriteLine("Helyezés;Név;Csoport;Nemzet;NemzetKód;Sorozat;Eredmény");
            for (int i = 0; i < dontobeJutottak.Count; i++)
            {
                sw.WriteLine($"{i + 1};{dontobeJutottak[i].ToString()}");
            }
            sw.Flush();
            sw.Close();
        }

        private static void F09()
        {
            Versenyzo legjobb = versenyzok.OrderByDescending(versenyzo => versenyzo.Eredmeny).First();

            Console.WriteLine("9. feladat: A selejtező nyertese:");
            Console.WriteLine($"\tNév: {legjobb.Nev}");
            Console.WriteLine($"\tCsoport: {legjobb.Csoport}");
            Console.WriteLine($"\tNemzet: {legjobb.Nemzet}");
            Console.WriteLine($"\tNemzet kód: {legjobb.Kod}");
            Console.WriteLine($"\tSorozat: {legjobb.DobasokAsString}");
            Console.WriteLine($"\tEredmény: {legjobb.Eredmeny}");
        }

        private static void F06()
        {
            int tovabbjutottakNagyDobassal = versenyzok.Count(versenyzo => versenyzo.Dobasok[1] == -2f || versenyzo.Dobasok[2] == -2f);

            Console.WriteLine($"6.feladat: 78,00 méter feletti eredménnyel továbbjutott: {tovabbjutottakNagyDobassal} fő");
        }

        private static void F05()
        {
            Console.WriteLine($"5. feladat: Versenyzők száma a selejtezőben: {versenyzok.Count} fő");
        }

        private static void F04()
        {
            using StreamReader sr = new($"{eleresiUt}Selejtezo2012.txt");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                versenyzok.Add(new(sr.ReadLine()));
            }
        }
    }
}