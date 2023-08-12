String[] TreeSimvolArray(String[] array)
{
    String[] resultArray = new String[array.Length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}

String[] array_1 = new String[] {"Hello", "2", "world", ":-)"};
String[] array_2 = new String[] {"1234", "1567", "-2", "computer science"};
String[] array_3 = new String[] {"Russia", "Denmark", "Kazan"};

PrintArray(TreeSimvolArray(array_1));
PrintArray(TreeSimvolArray(array_2));
PrintArray(TreeSimvolArray(array_3));