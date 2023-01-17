using System;
using System.Linq;
using System.Text;

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

    public string RemoveMoreThanOneSpaces(string userInput)
    {
        while (userInput.Contains("  "))
            userInput = userInput.Replace("  ", " ");
        return userInput;
    }

    public string FindTheLongestWord(string userInput)
    {
        string longestWord = "";
        string cleanedUserInput = RemoveMoreThanOneSpaces(userInput).Trim();
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

    static string StringToBinary(string inputString)
    {
        StringBuilder newString = new StringBuilder();

        foreach (char c in inputString.ToCharArray())
        {
            newString.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }
        return newString.ToString();
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

    public string HandleResponse(string userInput)
    {
        string output = "";
        if (userInput == "" || userInput.All(char.IsWhiteSpace))
        {
            output = "You did not enter any value";
        }
        else if (InputIsDecimal(userInput))
        {
            output = StringToBinary(userInput);
        }
        else if (InputIsString(userInput) && userInput.Trim().Contains(" "))
        {
            output = FindTheLongestWord(userInput).ToUpper();
        }
        else //(InputIsString(userInput))
        {
            output = ReverseString(userInput);
        }
        return output;
    }


}
