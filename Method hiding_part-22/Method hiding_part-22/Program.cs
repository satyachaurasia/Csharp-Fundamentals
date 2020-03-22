using System;

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

}

public class PartTimeEmploye : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "-Contractor");
    }
}

public class FullTimeEmployee : Employee
{

}

public class Program
{
   public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Full Time EMployee";
        FTE.LastName = "Employee";
        FTE.PrintFullName();

        PartTimeEmploye PTE = new PartTimeEmploye();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        PTE.PrintFullName();

        Console.ReadLine();
    }
}