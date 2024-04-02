using System;

class Program
{
    static void Main(string[] args)
    {
        string[][] examples = {
            new string[] { "DnD", "Dangeons", "and", "Dragons" },
            new string[] { "321", "4235", "-313", "57" },
            new string[] { "#$%^", "@!%", "😀" }
        };

        foreach (string[] inputArray in examples)
        {
            string[] newArray = FilterStrings(inputArray);

            Console.WriteLine("Исходный массив:");
            PrintArray(inputArray);
            Console.WriteLine("Отфильтрованный массив:");
            PrintArray(newArray);
            Console.WriteLine();
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int newIndex = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[newIndex++] = str;
            }
        }

        return newArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\"" + array[i] + "\"");
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}