// See https://aka.ms/new-console-template for more information
using System;
using static System.Formats.Asn1.AsnWriter;

// global variables
// hello!
string name = GetName();
var games = new List<string>();


DateTime date = DateTime.UtcNow;

Menu(name, date);


// methods
string GetName()
{
    Console.WriteLine("Please Type your Name: ");
    string name = Console.ReadLine();
    return name;
}

void Menu(string name, DateTime date)
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
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game selected");
                break;
            case "s":
                SubtractionGame("Subtraction game selected");
                break;
            case "m":
                MultiplicationGame("Multiplication game selected");
                break;
            case "d":
                DivisonGame("Division game selected");
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

void GetGames()
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

void AdditionGame(string message)
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

    games.Add($"{DateTime.Now} - Addition: Score = {score}");
     
}

void SubtractionGame(string message)
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

void MultiplicationGame(string message)
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

void DivisonGame(string message)
{
    Console.WriteLine(message);
    for( int i = 0; i<5; i++)
    {
        int[] divisionNumbers = GetDivisionNumbers();
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

int[] GetDivisionNumbers()
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