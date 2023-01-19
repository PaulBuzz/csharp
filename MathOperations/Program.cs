// See https://aka.ms/new-console-template for more information

// Basic Assignment Operator

int num;
num = 5;

// Ariphmetic Operators
int num1 = 11;
int num2 = 12;
int sum = num1 + num2;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Substraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 4; // or num1 += 4;
Console.WriteLine($"New value of num1: {num1 + num2}");
Console.WriteLine($"Substraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");


// Compound Assignment Operators

num1 += 4;
Console.WriteLine(num1);
num1 -= 4;
Console.WriteLine(num1);
num1 *= 4;
Console.WriteLine(num1);
num1 /= 4;
Console.WriteLine(num1);
num1 %= 4;
Console.WriteLine(num1);