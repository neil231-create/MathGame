namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {

            bool isGameOn = true;

            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your match game. That's great that you're working on improving yourself");
            do
            {

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine(@$"What game would you like to play today? Choose from the option below: 
                        A - Addition
                        S - Subtraction
                        M - Multiplication
                        D - Division
                        Q - Quit
                        V - Game History");
                Console.WriteLine("--------------------------------------------");
                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game selected");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game selected");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game selected");
                        break;
                    case "d":
                        gameEngine.DivisonGame("Division game selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (isGameOn);

        }
    }
}
