using System;

class Program
{
    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        ParamsMethod(1, 2, 3, 4);

        Console.ReadLine();
    }

    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements", Numbers.Length);

        foreach(int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}