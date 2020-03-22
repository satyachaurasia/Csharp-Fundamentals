using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passMark = 35;
    

    public string Email
    {
        set;
        get;
    }

    public string City
    {
        set;
        get;
    }

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = value;
        }

        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }

    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student Id Cannot be -ve");
            }
            this._id = value;
        }

        get
        {
            return this._id;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.Id = 101;
        C1.Name = "Mark";

        Console.WriteLine("Student ID: {0}", C1.Id);
        Console.WriteLine("Student  Name = {0}", C1.Name);
        Console.WriteLine("PassMark = {0}", C1.PassMark);

        Console.ReadLine();
    }
}