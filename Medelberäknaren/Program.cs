using System.Reflection;

namespace Medelberäknaren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            double summa1 = 0;
            double summa2 = 0;
            double antal = 0;
            double svar = 0;

            while (summa1 >= 0)
            {
                summa1 = Convert.ToInt32(Console.ReadLine());
                summa2 = summa2 + summa1;
                antal++;
                svar = summa2 / antal;
                Console.WriteLine("Medelvärdet är:");
                Console.WriteLine(svar);
                Console.WriteLine("Skriv in ett heltal:");
            }

        }
    }
    
}