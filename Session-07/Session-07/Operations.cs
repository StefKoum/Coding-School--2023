using System;
using System.Linq;

public class Operations
{
	public bool InputIsDecimal(string userInput)
    {
        decimal dec;
        if (Decimal.TryParse(userInput, out dec))
        {
            return true;
        }
        return false;
    }

    public bool InputIsString(string userInput)
    {
        return !(userInput.Any(char.IsDigit));
    }

    public string removeMoreThanOneSpaces(string userInput)
    {
        while (userInput.Contains("  "))
            userInput = userInput.Replace("  ", " ");
        return userInput;
    }

    public string findTheLongestWord(string userInput)
    {
        string longestWord = "";
        string cleanedUserInput = removeMoreThanOneSpaces(userInput).Trim();
        string[] arrayOfWords = cleanedUserInput.Split(" ");
        for (int i = 0; i < arrayOfWords.Length; i++)
        {
            if (arrayOfWords[i].Length > longestWord.Length)
            {
                longestWord = arrayOfWords[i];
            }
        }
        return longestWord;
    }

    public string ReverseString(string inputString)
    {
        if (inputString.Length > 0)
        {
            return inputString[inputString.Length - 1] +
                   ReverseString(inputString.Substring(0, inputString.Length - 1));
        }
        else return inputString;
    }



}
