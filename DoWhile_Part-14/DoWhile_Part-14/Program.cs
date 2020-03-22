using System;

class Program
{
    static void Main()
    {
        string UserChoice = "YES";
        do
        {
            Console.WriteLine("Please enter your target?");
            int UserTarget = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= UserTarget)
            {
                Console.Write(start + " ");
                start += 2;
            }

            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");
                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice!="YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid choice, please say Yes or No");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");

        } while (UserChoice == "YES");

        Console.ReadLine();
        

    }
}