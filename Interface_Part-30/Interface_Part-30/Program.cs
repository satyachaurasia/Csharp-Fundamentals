﻿using System;

interface ICustomer1
{
    void Print1();
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}

public class Customer : ICustomer2
{
    public void Print2()
    {
        Console.WriteLine("Print2");
    }

    public void Print1()
    {
        Console.WriteLine("Print1");
    }
}


public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print1();
        C1.Print2();

        Console.ReadLine();
    }
}