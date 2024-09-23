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
                        Console.WriteLine("var god skriv in två heltal som du vill multiplicera");
                        int firstInt = int.Parse(Console.ReadLine());
                        int secondInt = int.Parse(Console.ReadLine());
                        int product = Multi(firstInt,secondInt); //metod för att multiplicera
                        Console.WriteLine($"Resultat: {firstInt} * {secondInt} = {product}");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
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

        static int Multi (int firstInt, int secondInt)
        {
            int product = (firstInt * secondInt);
            return product;
        }
        static int Division (int firstInt, int secondInt)
        {
            int result = (firstInt / secondInt);
            return result;
        }
        static int Add(int addOne, int addTwo)
        {
            int result = (addOne + addTwo);
            return result;
        }
        static int subtraction(int subOne, int subTwo)
        {
            int result = (subOne - subTwo);
            return result;
        }
    }
}
