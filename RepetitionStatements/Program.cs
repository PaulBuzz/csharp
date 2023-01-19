// See https://aka.ms/new-console-template for more information

// For loop (counter controlled)
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("I am in a loop.");
//    Console.WriteLine($"Counter value: {i}");
//}

//Console.WriteLine();
//Console.WriteLine("For loop finished.");

// While loop (condition controlled -> pre check)

//int nameof = 0;
//while(nameof < 5)
//{
//    Console.WriteLine("Input a number: ");
//    nameof = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Your entered {nameof}: ");
//}

//Console.WriteLine();
//Console.WriteLine("While loop finished.");

// Do.. while loop (condition controlled -> post check)

int n = 0;
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Your entered {n}: ");
} while (n < 5);

Console.WriteLine();
Console.WriteLine("Do... while loop finished.");

// Foreach (Honorable mention)