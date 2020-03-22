using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");

        int UserNumber = int.Parse(Console.ReadLine());

        if (UserNumber == 1)
        {
            Console.WriteLine("Your Number is one");
        }
        else if (UserNumber == 2)
        {
            Console.WriteLine("Your Number is two");
        }
        else if (UserNumber == 3)
        {
            Console.WriteLine("Your Number is three");
        }
        else
        {
            Console.WriteLine("Your number is not between 1 and 3");
        }

        Console.ReadLine();
    }
}