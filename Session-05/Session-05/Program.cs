
    static void printArrElements(int[] inputArr)
    {
        for (int i = 0; i < inputArr.Length; i++)
        {
            Console.WriteLine(inputArr[i]);
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

    int[] firstArray = new int[] { 2, 4, 9, 12 };
    int[] secondArray = new int[] { 1, 3, 7, 10 };

printArrElements(multiplyTwoArrays(firstArray, secondArray));
Console.ReadLine();