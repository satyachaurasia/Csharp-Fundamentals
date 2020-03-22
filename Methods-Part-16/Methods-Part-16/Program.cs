using System;

class Program
{
    public static void Main()
    {
        Program.EvenNumbers(30);

        Program P = new Program();
        int sum = P.Add(10, 20);

        Console.WriteLine("Sum = {0}", sum);
        Console.ReadLine();
    }

    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers(int Target)
    {
        int start = 0;

        while (start <= Target)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }
}