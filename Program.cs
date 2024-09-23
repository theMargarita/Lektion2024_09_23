namespace Lektion2024_09_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Välkommen till miniräknaren!");
            while (true)
            {
                Console.WriteLine("Var god välj vad du vill göra");
                Console.WriteLine("1. Addera");
                Console.WriteLine("2. Subtrahera");
                Console.WriteLine("3. Multiplicera");
                Console.WriteLine("4. Dividera");
                Console.WriteLine("5. Avsluta miniräknaren");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        //metod för att addera
                        break;
                    case "2":
                        //metod för att subtrahera
                        break;
                    case "3":
                        //metod för att multiplicera
                        break;
                    case "4":
                        //metod för att dividera
                        break;
                    case "5":
                        Console.WriteLine("Tack för att du använde miniräknaren! Avslutar programmet..");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning, försök igen");
                        break;
                }
            }
        }
    }
}
