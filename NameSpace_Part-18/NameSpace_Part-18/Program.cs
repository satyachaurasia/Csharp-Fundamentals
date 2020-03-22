using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
class Program
{
    public static void Main()
    {
        PATA.ClassA.Print();
        PATB.ClassB.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassB
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}