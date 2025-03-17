using System.Linq.Expressions;

namespace PirmaisUzdevums
{
    public delegate double Matematika(double viens, double divi);

    public class Program
    {
        public static double Saskaitit(double viens, double divi)
        {
            double summa = viens + divi;
            return summa;
        }

        public static double Atnemt(double viens, double divi)
        {
            double starpiba = viens - divi;
            return starpiba;
        }

        public static double Reizinat(double viens, double divi)
        {
            double reizinajums = viens * divi;
            return reizinajums;
        }

        public static double Dalit(double viens, double divi)
        {
            double dalijums = viens / divi;
            return dalijums;
        }

        static void Main(string[] args)
        {
            Matematika del1 = null;
            Console.WriteLine("Izvelies darbibu 1 - saskaitit, 2 - atnemt, 3 - dalit, 4 - reizinat");
            int izvele = int.Parse(Console.ReadLine());
            switch (izvele)
            {
                case 1:
                    del1 = Saskaitit;
                    break;
                case 2:
                    del1 = Atnemt;
                    break;
                case 3:
                    del1 = Dalit;
                    break;
                case 4:
                    del1 = Reizinat;
                    break;
                default:
                    Console.WriteLine("Nav tadas izveles");
                    break;
            }
            Console.WriteLine("Ievadiet divus skaitlus:");
            Console.WriteLine("Ievadiet pirmo skaitli:");
            double pirmaisSkaitlis = double.Parse(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli:");
            double otraisSkaitlis = double.Parse(Console.ReadLine());
            double rezultats = del1(pirmaisSkaitlis, otraisSkaitlis);
            Console.WriteLine("Rezultats: " + rezultats);
        }
    }
}
