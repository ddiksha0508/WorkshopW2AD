DateTime birthDate = new DateTime(2005, 8, 25);
DateTime currentDate = DateTime.Now;

TimeSpan ageSpan = currentDate - birthDate;
int age = (int)(ageSpan.TotalDays / 365.25);

Console.WriteLine($"Birthdate: {birthDate:YYYY-MM-DD}");
Console.WriteLine($"Current Date: {currentDate:YYYY-MM-DD}");
Console.WriteLine($"Age: {age} years");

DateTime newDate = birthDate.AddDays(10);
Console.WriteLine($"Birthdate + 10 Days: {newDate:YYYY-MM-DD}");