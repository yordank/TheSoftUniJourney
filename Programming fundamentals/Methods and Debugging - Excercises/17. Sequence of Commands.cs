using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = command.Trim();
            int[] args = new int[2];

            if (command.Split(' ')[0].Equals("add") ||
                command.Split(' ')[0].Equals("subtract") ||
                command.Split(' ')[0].Equals("multiply"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                PerformAction(array, command.Split(' ')[0], args);
            }

            //PerformAction(array, command, args);
            if (command.Split(' ')[0].Equals("rshift") ||
                command.Split(' ')[0].Equals("lshift") 
               )
            {
                PerformAction(array, command.Split(' ')[0], args);

            }

            PrintArray(array);
               
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

    static void PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr  as long[];
        int pos = args[0]-1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
    }

    private static void ArrayShiftRight(long[] array)
    {
        long a = array[array.Length-1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = a;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long a=array[0];


        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = a;

    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
