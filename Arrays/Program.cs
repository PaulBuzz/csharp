// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array
int[] grades = new int[5];
// 5 space addresses - 0, 1, 2, 3, 4
// if n is the size of the array, then your array has addresses of 0 to n-1

// Add values to fixed size array
//grades[0] = 1;
//grades[1] = 2;
//grades[2] = 12;
//grades[3] = 22;
//grades[4] = 44;
//grades[5] = 60;

//int[] grades = new int[] { 1, 25, 48, 49, 50 };
Console.WriteLine("Enter All Grades");
for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in fixed size array

Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}


// Declare Variable Sized Array
string[] studentNames = new string[] { "Test", "Student", "Etc..." };
// Add value to variable sized array
Console.WriteLine("Enter All Names");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter Name: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in variable sized array
Console.WriteLine("The Names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}

