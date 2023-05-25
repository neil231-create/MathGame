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
    }
}
