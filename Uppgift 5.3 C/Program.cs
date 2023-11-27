using System; 
namespace Uppgift_5_3_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Frågor = new string[4] { "Vad heter Markus", "Vad heter håkan", "Vad heter huvudstaden i Svergie", "När är jag född" };
            string[] svar = new string[4] { "Markus", "Håkan", "Stockholm", "2006" };

            Console.WriteLine("Välj ett frågealternativ från 1-4");
            int alt = int.Parse(Console.ReadLine());
            Console.WriteLine(Frågor[alt-1]);
            string xsvar = Console.ReadLine();

            if (xsvar == svar[alt-1])
            {
                Console.WriteLine("Du svarade rätt!!");
            }
            else
            {
                Console.WriteLine("Fel, rätt svar var " + svar[alt-1]);
            }
        }
    }
}