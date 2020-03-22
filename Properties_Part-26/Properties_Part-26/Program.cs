using System;

public class Student
{
    private int _id;
    private string _name;
    private int _passMark;

    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student ID should be greater than zero");
        }
        this._id = Id;
    }

    public int GetId()
    {
        return this._id;
    }

    public void SetName(string Name)
    {
        if (String.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be null or empty");
        }
        this._name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
    }

}

public class Progrma
{
    public static void Main()
    {
        Student C1 = new Student();
        C1.SetId(101);
        C1.SetName("Berk Macklin");

        Console.WriteLine("Student ID= {0}", C1.GetId());
        Console.WriteLine("Student Name= {0}", C1.GetName());

        Console.ReadLine();
    }
}