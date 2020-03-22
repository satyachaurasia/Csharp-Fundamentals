using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor called");
    }
    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived class controlling Parent Class")
    {
        Console.WriteLine("ChildClass Constructor called");
    }
}

public class Program
{
    public static void Main()
    {
        ChildClass CC = new ChildClass();

        Console.ReadLine();

    }
}