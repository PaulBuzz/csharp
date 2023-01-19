// See https://aka.ms/new-console-template for more information
string firstName = "Pavel";
string lastName = "Buzin";
DateTime date = DateTime.Now;

// print a string
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// concatination
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("Ny full name is: " + lastName + " " + firstName);
Console.WriteLine($"Ny full name is: {lastName}, {firstName}"); // intrapolation
Console.WriteLine("Ny full name is: {0}, {1}", lastName, firstName); // placeholders

// string length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long.");

// replace string parts
string newName = firstName.Replace('P', 'R');
Console.WriteLine($"Your new name is {newName}.");

string newName1 = firstName.Replace('e', ' ');
Console.WriteLine($"Your new name is {newName1}.");

// append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}.");

// split string
string[] splitName = fullName.Split('v'); // делит строку до указанной буквы на 2 стринга, поэтому нужно [] - array
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// compare strings
string nullString = null;
string emptyString = string.Empty; // = "";
string whitespaceString = " ";

if(string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("Names are equal.");
}

if (firstName != lastName)
{
    Console.WriteLine("Names are not eqausl.");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal.");
}
else
{
    Console.WriteLine("Names aren't equal.");
}

// convert to string
string convertedString = string.Empty;
int number = 1230981231;

convertedString = 1230981231.ToString();
convertedString = number.ToString();

fullName.ToUpper();
fullName.ToLower();
