// See https://aka.ms/new-console-template for more information

// If statements ( == equvalence, != not equal, <, >, <=, >= )
using System;

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples.");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more oranges.");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have equal amount of apples and oranges.");
}
else
{
    Console.WriteLine("No direct value.");
}

// Switch statements
Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch (grade)
{
    case int n when n >= 0 && n <= 59: // between 0 & 59
        Console.WriteLine("You failed.");
        break;
    case int n when n >= 60 && n <= 100: // between 60 & 100
        Console.WriteLine("You passed.");
        Console.WriteLine("You passed.");
        Console.WriteLine("You passed.");
        Console.WriteLine("You passed.");
        Console.WriteLine("You passed.");
        break;
    case 101:
        Console.WriteLine("Single case example.");
        break;
    default:
        Console.WriteLine("Invalid grade.");
        break;
}


// Ternary operators

//var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";
//Console.WriteLine(message);