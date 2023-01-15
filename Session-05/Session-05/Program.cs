/********************
* Main Program
*********************/

using System.Text;

Console.WriteLine("Exercise 1. Write a C# program that reverses a given string (your name)\n");
string myName = "Stefanos";
Console.WriteLine($"My name is {myName} and my name reversed is {reverseString(myName)}.");



Console.WriteLine("\n\n\nExercise 2. Write a C# program that asks the user for an integer (n) and gives\nthem the possibility to choose between computing the sum or the product of 1, ... , n\n");
Console.WriteLine($"The result of the chosen operation is {chooseOperation()}.");



Console.WriteLine("\n\n\nExercise 3. Write a C# program that asks the user for an integer (n) and finds all the prime numbers from 1 to n\n");
int userNumber = getPositiveIntegerInput();
Console.WriteLine($"Prime numbers up to {userNumber} are:");
printPrimesUpToNumber(userNumber);



Console.WriteLine("\n\n\nPress any key to see the 2 remaining exercises...");
Console.ReadLine();



Console.WriteLine("\n\n\nExercise 4. Write a C# Program to multiply all the values from Array1\nwith all values from Array2 and display the results in a new Array");
Console.WriteLine("- Array1: [2, 4, 9, 12]");
Console.WriteLine("- Array2: [1, 3, 7, 10]\n");
int[] firstArray = new int[] { 2, 4, 9, 12 };
int[] secondArray = new int[] { 1, 3, 7, 10 };
Console.WriteLine($"The initial arrays, the elements of which we want to multiply:");
Console.WriteLine($"{stringifyArrayOfInts(firstArray)} and {stringifyArrayOfInts(secondArray)}");
Console.WriteLine("\nThe produced array after the multiplication of all the elements of the two arrays above:");
Console.WriteLine(stringifyArrayOfInts(multiplyTwoArrays(firstArray, secondArray)));



Console.WriteLine("\n\n\nExercise 5. Write a C# program to sort the given array of integers from the lowest to the highest number");
Console.WriteLine("- Array: [0, -2, 1, 20, -31, 50, -4, 17, 89, 100]\n");
int[] arrayToSort = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
Console.WriteLine("The initial array:");
Console.WriteLine(stringifyArrayOfInts(arrayToSort));
Console.WriteLine("*** The sorted array: ***");
Console.WriteLine(stringifyArrayOfInts(arrayBubbleSortAscending(arrayToSort)));

Console.ReadLine();
////////////////////////





/*****************************
* Helper functions (Utilities)
******************************/
static int getPositiveIntegerInput()
{
    Console.Write("Please enter a positive integer greater than 1:  ");
    while (true)
    {
        int initialUserInput;
        string message = "The value you entered is not a valid one. Please try again:  ";
        try
        {
            initialUserInput = Convert.ToInt32(Console.ReadLine());
        }
        catch // TODO: Να μελετήσω το τύπο της συγκεκριμένης εξαίρεσης
        {
            Console.Write(message);
            continue;
        }
        if (initialUserInput < 2)
        {
            Console.Write(message);
            continue;
        }
        return initialUserInput;
    }
}

static void printArrElements(int[] inputArray)
{
    foreach (int element in inputArray)
        Console.WriteLine(element);
}

static string stringifyArrayOfInts(int[] inputArray)
{
    StringBuilder arrayString = new StringBuilder();
    arrayString.Append("[ ");
    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        arrayString.Append($"{inputArray[i]}, ");
    }
    arrayString.Append($"{inputArray[inputArray.Length - 1]} ]");
    return arrayString.ToString();
}

static int[] shallowArrayCopy(int[] inputArray)
{
    int arrLength = inputArray.Length;
    int[] clonedArray = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        clonedArray[i] = inputArray[i];
    }
    return clonedArray;
}
/////////////////////////////////////




/*********************************
* Functions for exercise solving
**********************************/
static string reverseString(string inputString)
{
    StringBuilder newString = new StringBuilder();
    for (int i = inputString.Length - 1; i >= 0; i--)
    {
        newString.Append(inputString[i]);
    }
    return newString.ToString();
}

static int calcSumOfNumsFromOneUpTo(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++) result += i;
    return result;
}

static int calcProdOfNumsFromOneUpTo(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++) result *= i;
    return result;
}


static int chooseOperation()
{
    Console.Write("Please choose Operation. Type\n'p' if you want to calculate the product or \n's' if you would prefer to calculate the sum of 1 up to a number:  ");
    while (true)
    {
        string userInput = Console.ReadLine();
        string cleanedUserInput = userInput.Trim().ToLower();
        if (cleanedUserInput == "p")
        {
            return calcProdOfNumsFromOneUpTo(getPositiveIntegerInput());
        }
        else if (cleanedUserInput == "s")
        {
            return calcSumOfNumsFromOneUpTo(getPositiveIntegerInput());
        }
        else
        {
            Console.Write("Invalid input. Please repeat with a valid one:  ");
            continue;
        }
    }
}


static bool isPrime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

static void printPrimesUpToNumber(int number)
{
    for (int i = 2; i <= number; i++)
    {
        if (isPrime(i))
            Console.WriteLine(i);
    }
}


static int[] multiplyTwoArrays(int[] firstArr, int[] secondArr)
{
    int[] newArray = new int[firstArr.Length * secondArr.Length];
    int index = firstArr.Length * secondArr.Length;
    for (int i = 0; i < firstArr.Length; i++)
    {
        for (int j = 0; j < secondArr.Length; j++)
        {
            newArray[newArray.Length - index] = firstArr[i] * secondArr[j];
            index -= 1;
        }
    }
    return newArray;
}


static int[] arrayBubbleSortAscending(int[] inputArray)
{
    int[] clonedArray = shallowArrayCopy(inputArray);
    for (int i = 0; i < clonedArray.Length; i++)
    {
        for (int j = 0; j < clonedArray.Length; j++)
        {
            if (/*i != j &&*/ clonedArray[i] < clonedArray[j])
            {
                int temporaryVar = clonedArray[i];
                clonedArray[i] = clonedArray[j];
                clonedArray[j] = temporaryVar;
            }
        }
    }
    return clonedArray;
}

static int[] arrayInsertionSort(int[] inputArray)
{
    // Με τη συγκεκριμένη δομή ξεκινώ να ελέγχω από το τελευταίο στοιχείο
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = inputArray.Length - 1; j > 0; j--)
    // Εναλλακτικά η εκκίνηση θα μπορούσε να γίνει απευθείας από το 2ο στοιχείο ως εξής:
    //for (int i = 1; ...) {
        //for (int j = i; ...) {
        {
            if (inputArray[j] < inputArray[j - 1])
            {
                int temporaryVar = inputArray[j];
                inputArray[j] = inputArray[j - 1];
                inputArray[j - 1] = temporaryVar;
            }
        }
    }
    return inputArray;
}

//int[] arrayToSort = new int[] { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
//Console.WriteLine(
    //stringifyArrayOfInts(
        //shallowArrayCopy(
            //arrayInsertionSort(arrayToSort)
        //)
    //)
//);

///////////////////////////////////////



