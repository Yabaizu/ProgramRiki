using System.Linq.Expressions;

namespace OtraisUzdevums
{
    public delegate double Matematika(double viens, double divi);

    public class Program
    {

        static void Main(string[] args)
        {
            Matematika del1 = null;
            Console.WriteLine("Izvelies darbibu 1 - saskaitit, 2 - atnemt, 3 - dalit, 4 - reizinat");
            int izvele = int.Parse(Console.ReadLine());
            switch (izvele)
            {
                case 1:
                    del1 = delegate (double viens, double divi)
                    {
                        return viens + divi;
                    };
                    break;
                case 2:
                    del1 = delegate (double viens, double divi)
                    {
                        return viens - divi;
                    };
                    break;
                case 3:
                    del1 = delegate (double viens, double divi)
                    {
                        return viens / divi;
                    };
                    break;
                case 4:
                    del1 = delegate (double viens, double divi)
                    {
                        return viens * divi;
                    };
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

