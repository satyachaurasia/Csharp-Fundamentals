using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your target?");
        int UserTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while (start <= UserTarget)
        {
            Console.Write(start + " ");
            start += 2;
        }

        Console.ReadLine();
    }
}