namespace Lektion2024_09_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            Console.WriteLine("Välkommen till den fantastiska miniräknaren!");
            while (isRunning)
            {
                Console.WriteLine("Var god välj vad du vill göra");
                Console.WriteLine("1. Addera");
                Console.WriteLine("2. Subtrahera");
                Console.WriteLine("3. Multiplicera");
                Console.WriteLine("4. Dividera");
                Console.WriteLine("5. Avsluta miniräknaren\n");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nVar god skriv in två heltal som du vill multiplicera");
                        int addOne = int.Parse(Console.ReadLine());
                        int addTwo = int.Parse(Console.ReadLine());
                        int result = Add(addOne, addTwo); 
                        Console.WriteLine($"Resultat: {addOne} + {addTwo} = {result}");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("\nVar god skriv in två heltal som du vill multiplicera");
                        int subOne = int.Parse(Console.ReadLine());
                        int subTwo = int.Parse(Console.ReadLine());
                        int resultTwo = Subtraction(subOne, subTwo);
                        Console.WriteLine($"Resultet: {subOne} - {subTwo} = {resultTwo}\n");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("\nVar god skriv in två heltal som du vill multiplicera");
                        int firstInt = int.Parse(Console.ReadLine());
                        int secondInt = int.Parse(Console.ReadLine());
                        int product = Multi(firstInt, secondInt); 
                        Console.WriteLine($"Resultat: {firstInt} * {secondInt} = {product}\n");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("\nVar god skriv in två heltal som du vill dividera");
                        int intOne = int.Parse(Console.ReadLine());
                        int intTwo = int.Parse(Console.ReadLine());
                        int resultOne = Division(intOne, intTwo); 
                        Console.WriteLine($"Resultat: {intOne} / {intTwo} = {resultOne}");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("\nTack för att du använde miniräknaren! Avslutar programmet..\n");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Felaktig inmatning, försök igen\n");
                        break;
                }
            }
        }
        static int Multi(int firstInt, int secondInt)
        {
            int product = (firstInt * secondInt);
            return product;
        }
        static int Division(int firstInt, int secondInt)
        {
            int result = (firstInt / secondInt);
            return result;
        }
        static int Add(int addOne, int addTwo)
        {
            int result = (addOne + addTwo);
            return result;
        }
        static int Subtraction(int subOne, int subTwo)
        {
            int result = (subOne - subTwo);
            return result;
        }
    }
}
