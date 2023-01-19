// See https://aka.ms/new-console-template for more information


/* 
 try - a try block attempts an operation
catch - catch any fatal error or exception while running
finally - whether the try or the catch was successful, do this
throw - end program execution with the error
 */


Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
try
{
    int quotient = number1 / number2;
    Console.WriteLine("Result is : " + quotient.ToString());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal operation: {ex.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("This is the end of the programm.");
}


