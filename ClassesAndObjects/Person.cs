// See https://aka.ms/new-console-template for more information

public class Person
{
    // properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


    // fields - private, no capital letters
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    {
        return _salary;
    }


    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName (string middleName)
    {
        return $"{FirstName} {middleName} {LastName}";
    }
}