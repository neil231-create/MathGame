// See https://aka.ms/new-console-template for more information
using System;

// global variables
string name = GetName();
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
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your match game. That's great that you're working on improving yourself");
    Console.WriteLine(@$"What game would you like to play today? Choose from the option below: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
    Console.WriteLine("--------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
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
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(1);
            break;
    }

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
    Console.WriteLine("Five tries only");
    var random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();


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

