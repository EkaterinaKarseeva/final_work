// Решение

using System;

class Program
{
    static string[] FilterStrings(string[] arr)
    {
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
            {
                result[index++] = str;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        string[] strings = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        string[] filteredStrings = FilterStrings(strings);

        Console.WriteLine("Отфильтрованный массив строк:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }
}

