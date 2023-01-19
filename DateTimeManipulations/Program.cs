// See https://aka.ms/new-console-template for more information

using System.Globalization;

// empty datetime
DateTime date = new DateTime(); // initialize datetime object, datetime is class


// create a datetime from date and time
DateTime dateOfBirth = new DateTime(1992, 02, 12);
Console.WriteLine("My dob is: " + dateOfBirth);
Console.WriteLine("My dob is: " + dateOfBirth.Date);

Console.WriteLine("Day of week: {0} ", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of year: {0} ", dateOfBirth.DayOfYear);
Console.WriteLine("Time of day: {0} ", dateOfBirth.TimeOfDay);
Console.WriteLine("Ticks: {0} ", dateOfBirth.Ticks);
Console.WriteLine("Kind: {0} ", dateOfBirth.Kind);

// create a datetime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("My time now is: " + now);

// create a datetime from a string
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is " + dateFromString);

// add additional time
now.AddHours(1);
Console.WriteLine("One hour from now is  " + now.AddHours(1));
Console.WriteLine("One day from now is  " + now.AddDays(1));

// ticks from datetime - number of clock ticks
Console.WriteLine("Time as a numberal: " + now.Ticks);

// date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date only: " + dateOnlyOfBirth);

// time only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only: " + timeOnlyOfBirth);

