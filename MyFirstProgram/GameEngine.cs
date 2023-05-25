namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Five tries only");
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect");
                }
                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");


            }

            

        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Five tries only");
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();


                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect");
                }
                if (score == 4) Console.WriteLine($"Game over you score is {score}");
            }
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Five tries only");
            var random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();


                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect");
                }
                if (score == 4) Console.WriteLine($"Game over you score is {score}");
            }
        }

        internal void DivisonGame(string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < 5; i++)
            {
                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];
                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();
                int score = 0;

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect");
                }
                if (score == 4) Console.WriteLine($"Game over you score is {score}");
            }
        }
    }
}
