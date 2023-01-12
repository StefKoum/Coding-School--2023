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



Console.ReadLine();




