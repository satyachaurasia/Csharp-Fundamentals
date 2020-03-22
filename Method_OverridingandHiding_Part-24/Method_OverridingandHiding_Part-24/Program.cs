using System;

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I'm a base class Print Method");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I'm a Derived Class Print Method");
    }
}

public class Program
{
    public static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print();

        DerivedClass D = new DerivedClass();
        D.Print();

        Console.ReadLine();
    }
}