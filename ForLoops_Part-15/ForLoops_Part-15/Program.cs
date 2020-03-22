using System;

class Program
{
    static void Main()
    {
        for(int i = 0; i<=20; i++)
        {
            if (i % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}