using System;

class Customer
{
    string _firstName;
    string _lastName;

    public Customer()
        : this("No First Name", "No Last Name")
    {

    }

    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name: " + this._firstName + " " + this._lastName);
    }

    ~Customer()
    {

    }
}

class Program
{
    public static void Main()
    {
        Customer c1 = new Customer();

        c1.PrintFullName();

        Customer c2 = new Customer("Bert", "Macklin");

        c2.PrintFullName();

        Console.ReadLine();

    }
}