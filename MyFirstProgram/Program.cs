// See https://aka.ms/new-console-template for more information
using System;
using static System.Formats.Asn1.AsnWriter;
using MyFirstProgram;

// global variables
// hello!

string name = GetName();
var games = new List<string>();

Menu menu = new Menu();
menu.ShowMenu(name, DateTime.Now);


DateTime date = DateTime.UtcNow;


// methods
string GetName()
{
    Console.WriteLine("Please Type your Name: ");
    string name = Console.ReadLine();
    return name;
} 



