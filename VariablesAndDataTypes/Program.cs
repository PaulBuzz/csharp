﻿// Variablesstring fullName = string.Empty;int age;double salary = 0.0;char gender = char.MinValue;bool working = false;Console.Write("Please enter your name: ");fullName = Console.ReadLine();Console.Write("Please enter your age: ");age = Convert.ToInt32(Console.ReadLine());Console.Write("Please enter your salary: ");salary = Convert.ToDouble(Console.ReadLine());Console.Write("Please enter your gender (M or F): ");gender = Convert.ToChar(Console.ReadLine());Console.Write("Please enter your working status (true or false): ");working = Convert.ToBoolean(Console.ReadLine());// PrintConsole.WriteLine("Your name is: " + fullName); // concatinationConsole.WriteLine("Your age is: {0}", age); // args ({} - placeholders, can be listed {0}, {1}, etc and then variable like: age, working, etcConsole.WriteLine($"Your salary is: {salary}"); // interpolationConsole.WriteLine($"Your gender is: {gender}");Console.WriteLine($"Your working status is: {working}");