// See https://aka.ms/new-console-template for more information
using System;
using static System.Formats.Asn1.AsnWriter;
using MyFirstProgram;

// global variables
// hello!

string name = Helpers.GetName();
var games = new List<string>();

Menu menu = new Menu();
menu.ShowMenu(name, DateTime.Now);


DateTime date = DateTime.UtcNow;


// methods




