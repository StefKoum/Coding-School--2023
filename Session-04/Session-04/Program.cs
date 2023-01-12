Console.WriteLine("\n1. Write a C# Program to print Hello and your name in the same line.");
//1. Write a C# Program to print Hello and your name in the same line.
string hello = "Hello";
string name = "Stefanos";
Console.WriteLine(hello + " " + name);




Console.WriteLine("\n2. Write a C# Program to print the sum of two numbers and the division of those two numbers.");
//2. Write a C# Program to print the sum of two numbers and the division of those two numbers.
double numberA = 50;
double numberB = 80;
int sum = (int) (numberA + numberB);
double division = numberB / numberA;
Console.WriteLine("The sum of the two numbers is: " + numberA + " + " + numberB + " = " + sum);
Console.WriteLine("The division of the two numbers is: " + numberB + " / " + numberA + " = " + division);




Console.WriteLine("\n3. Write a C# Program to print the reuslt of the specified operations.");
//3. Write a C# Program to print the reuslt of the specified operations.
// -1 + 5 x 6
// 38 + 5 mod 7
// 14 + ((-3 x 6) / 7)
// 2 + ((13.0 / 6.0) * 6.0) + Math.Sqrt(7)
// (6^4 + 5^7) / (9 mod 4)
Console.WriteLine("1st Operation = " + (-1 + (5 * 6)));
Console.WriteLine("2nd Operation = " + (38 + (5 % 7)));
Console.WriteLine("3rd Operation = " + ( 14 +  ( (double)(-3 * 6) / 7 )  ) );
Console.WriteLine("4th Operation = " + ( 2 + ( (13.0 / 6.0) * 6.0) + Math.Sqrt(7) ) );
double numerator = Math.Pow(6, 4) + Math.Pow(5, 7);
Console.WriteLine("5th Operation = " + (  numerator / (9 % 4) )  );




Console.WriteLine("\n4. Write a C# Program that assigns an age (number) and a gender (string)\n   and displays something like \"You are female and look younger than 20.\" ");
// 4. Write a C# Program that assigns an age (number) and a gender (string)
//    and displays something like "You are female and look younger than 20."
string gender = "female";
int age = 20;
Console.WriteLine("You are " + gender + " and look younger than " + age );




Console.WriteLine("\n5. Write a C# Program that takes an integer representing seconds (e.g. 45678) and converts it to:");
Console.WriteLine("  -Minutes, \n  -Hours, \n  -Days");
// 5. Write a C# Program that takes an integer representing seconds and converts it to:
// - Minutes,
// - Hours,
// - Days,
int seconds = 456787364;
int seconds2 = seconds;

int days = seconds / ((60 * 60) * 24);
seconds %= ((60 * 60) * 24);

int hours = seconds / (60 * 60);
seconds %= (60 * 60);

int minutes = seconds / 60;
seconds %= (60 * 60);

seconds %= 60;
Console.WriteLine(seconds2 + " seconds when converted result in: " + days + " day(s) " + hours + " hours " + minutes + " minutes and " + seconds + " seconds");
Console.WriteLine(seconds2 + " seconds are equivalent to: " + (days / 365) + " year(s) or " + (seconds2 / (3600 * 24)) + " day(s) or " + (seconds2 / (60 * 60)) + " hours or " + (seconds2/60) + " minutes.");




Console.WriteLine("\n6. Rewrite Program #5 using .Net Libraries.");
// 6. Rewrite Program #5 using .Net Libraries.
TimeSpan time = TimeSpan.FromSeconds(seconds2);
Console.WriteLine(seconds2 + " seconds when converted result in: " + time.Days + " day(s) " + time.Hours + " hours " + time.Minutes + " minutes and " + time.Seconds + " seconds");
Console.WriteLine(seconds2 + " seconds are equivalent to: " + ((int)time.TotalDays / 365) + " year(s) or " + (int)time.TotalDays + " day(s) or " + (int)time.TotalHours + " hours or " + (int)time.TotalMinutes + " minutes.");




Console.WriteLine("\n7. Write a C# Program to convert from Celcius degrees to Kelvin and Fahrenheit.");
// 7.  Write a C# Program to convert from Celcius degrees to Kelvin and Fahrenheit.
double celciusDeg = 30;
double kelvinDeg = celciusDeg + 273.15;
double fahrenheitDeg = (celciusDeg * 1.8) + 32;
Console.WriteLine(celciusDeg + "°C are equivalent to " + kelvinDeg + "°K or " + fahrenheitDeg + "°F.");

Console.ReadLine();




