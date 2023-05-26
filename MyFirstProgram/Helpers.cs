namespace MyFirstProgram
{
    internal class Helpers
    {
        static List<string> games;
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games history");
            Console.WriteLine("-----------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Games history");
        }



        internal static int[] GetDivisionNumbers()
        {

            Random random = new Random();

            int firstNumber = random.Next(0, 99);
            int secondNumber = random.Next(0, 99);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;



            Console.WriteLine(result);

            return result;
        }

        internal static string? Validate(string? result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an Integer. Try Again");
                result = Console.ReadLine();
            }
            return result; 
        }

        internal static string GetName()
        {
            Console.WriteLine("Please Type your Name: ");
            string name = Console.ReadLine();
           

            while (string.IsNullOrEmpty(name))
            {   
                Console.WriteLine("Name cant be empty");
                name = Console.ReadLine();
            }
            return name;
        }

    }
}
