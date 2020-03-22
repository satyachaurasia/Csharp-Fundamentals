using System;

class Program
{
    static void Main()
    {
        string strNumber = "9987";

        int Result = 0;

        bool IsConversionSuccessful = int.TryParse(strNumber, out Result);

        if (IsConversionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }

        Console.ReadLine();
    }
}