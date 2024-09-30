using System.Globalization;

namespace HarDuKörkort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool hasdriverlicens = false;

            Console.WriteLine("Vad är din ålder : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Har du giltigt körkort? : ");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "JA")
            {
                hasdriverlicens = true;
            }
            else
            {
                hasdriverlicens = false;
            }

            if (hasdriverlicens && age >= 18)
            {
                Console.WriteLine("Du får köra bil!");
            }
            else
            {
                Console.WriteLine("Du får inte köra bil");
            }


            {


            }
        }

    }
}
