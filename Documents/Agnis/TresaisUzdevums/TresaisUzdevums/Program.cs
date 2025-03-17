using System;
using System.Collections.Generic;

namespace TresaisUzdevums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> skaitluSaraksts = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int skaitlis = rnd.Next(1, 101);
                skaitluSaraksts.Add(skaitlis);
                Console.WriteLine($"Skaitlis {i + 1}: {skaitlis}");
            }

            Predicate<int> irPirmskaitlis = delegate (int skaitlis)
            {
                if (skaitlis < 2) return false;
                for (int i = 2; i < skaitlis; i++)
                {
                    if (skaitlis % i == 0) return false;
                }
                return true;
            };

            var pirmskaitli = skaitluSaraksts.FindAll(irPirmskaitlis);
            Console.WriteLine("\nPirmskaitļi sarakstā:");
            pirmskaitli.ForEach(Console.WriteLine);

            int pirmaisPirmskaitlis = skaitluSaraksts.Find(irPirmskaitlis);
            Console.WriteLine($"\nPirmais atrastais pirmskaitlis: {pirmaisPirmskaitlis}");

            bool iznems = skaitluSaraksts.Remove(pirmaisPirmskaitlis);
            Console.WriteLine($"\nVai pirmais pirmskaitlis tika izņemts: {iznems}");

            int iznemtiSkaitli = skaitluSaraksts.RemoveAll(irPirmskaitlis);
            Console.WriteLine($"\nIzņemto pirmskaitļu skaits: {iznemtiSkaitli}");

            Console.WriteLine("\nSaraksts pēc pirmskaitļu izņemšanas:");
            skaitluSaraksts.ForEach(Console.WriteLine);
        }
    }
}