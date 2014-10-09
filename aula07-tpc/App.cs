using System;

/*
 * Employee <- Operator 
 * Employee <- Manager <- Boss <- Owner
 */
class Employee
{
    public override String ToString()
    {
        return "I am Employee";
    }

}

class Operator : Employee
{

    public override String ToString()
    {
        return "I am Operator";
    }

}

class Manager : Employee
{

    public new virtual String ToString()
    {
        return "I am Manager";
    }

}

class Boss : Manager
{

    public override String ToString()
    {
        return "I am Boss";
    }

}

class Owner : Boss
{

    public override String ToString()
    {
        return "I am Owner";
    }

}

/*
 * Employee <- Operator 
 * Employee <- Manager <- Boss <- Owner
 */
class Program
{
    static void Main()
    {
        Employee e = new Owner();

        // Console.WriteLine(((Object)e).ToString());   // I am Employee
        Console.WriteLine(e.ToString());             // I am Employee
        Console.WriteLine(((Manager)e).ToString());  // I am Owner
        Console.WriteLine(((Boss)e).ToString());     // I am Owner
        Console.WriteLine(((Owner)e).ToString());    // I am Owner
    }
}