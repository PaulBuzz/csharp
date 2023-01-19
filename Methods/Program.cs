// See https://aka.ms/new-console-template for more information


// Prototype -> defines the functions (type, name and parameteres)
// Definition -> has the code, contains code block
// Function call -> makes the function
// DRY - DON'T REPEAT YOURSELF
// YAGNI - YOU AREN'T GOING TO NEED IT

// Void functions -> complete a task and move along
void PrintName()
{
    Console.WriteLine("Pavel Buzin");
}

PrintName();
Console.WriteLine("End of void function.");

void Addition(int num1, int num2)
{
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest < num2)
    {
        largest = num2;
    }

    if (largest < num3)
    {
        largest = num3;
    }

    return largest;
}

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

// Value returning functions -> complete a task and returns a result

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");
//Console.WriteLine($"The largest number is: {LargestNumber(number1, number2, number3)}");


