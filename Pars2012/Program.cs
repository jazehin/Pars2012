using System.Security;

namespace Pars2012
{
    internal class Program
    {
        static void Main()
        {
            //4
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            using StreamReader sr = new("./../../../../src/Selejtezo2012.txt");
            sr.ReadLine();
            while (!sr.EndOfStream) 
                versenyzok.Add(new Versenyzo(sr.ReadLine().Split(";")));

            //5
            Console.WriteLine($"5. feladat: Versenyzők száma a selejtezőben: {versenyzok.Count} fő");

            //6
            Console.WriteLine($"6. feladat: 78,00 méter feletti eredménnyel továbbjutott: {versenyzok.Count(v => v.Dobasok[0] > 78 || v.Dobasok[1] > 78)} fő");

            //9
            Versenyzo legnagyobb = versenyzok.MaxBy(v => v.Eredmeny);
            Console.WriteLine("9. feladat: A selejtező nyertese:");
            Console.WriteLine($"\tNév: {legnagyobb.Nev}");
            Console.WriteLine($"\tCsoport: {legnagyobb.Csoport}");
            Console.WriteLine($"\tNemzet: {legnagyobb.Nemzet}");
            Console.WriteLine($"\tNemzet kód: {legnagyobb.Kod}");
            Console.WriteLine($"\tSorozat: {legnagyobb.DobasokStr}");
            Console.WriteLine($"\tEredmény: {legnagyobb.Eredmeny}");

            //10
            versenyzok = versenyzok.OrderByDescending(v => v.Eredmeny).ToList();
            using StreamWriter sw = new("./../../../../src/Dontos2012.txt");
            sw.WriteLine("Helyezés;Név;Csoport;Nemzet;NemzetKód;Sorozat;Eredmény");
            for (int i = 0; i < 12; i++)
            {
                Versenyzo v = versenyzok[i];
                sw.WriteLine($"{i + 1};{v.Nev};{v.Csoport};{v.Nemzet};{v.Kod};{v.DobasokStr};{v.Eredmeny}");
            }
        }
    }
}