using System;

/*
 * Employee <- Operator 
 * Employee <- Manager <- Boss <- Owner
 */
class Employee
{
    public override String ToString()
    {
        return "Employee";
    }

}

class Operator : Employee
{

    public override String ToString()
    {
        return "Operator";
    }

}

class Manager : Employee
{

    public new virtual String ToString()
    {
        return "Manager";
    }

}

class Boss : Manager
{

    public override String ToString()
    {
        return "Boss";
    }

}

class Owner : Boss
{

    public override String ToString()
    {
        return "Owner";
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
        Employee opr = new Operator();
        
        Console.WriteLine(e.ToString());
        Console.WriteLine(((Manager)e).ToString());
        Console.WriteLine(((Boss)e).ToString());
        Console.WriteLine(((Owner)e).ToString());

        Console.WriteLine(opr);
        Console.WriteLine((Operator)opr);
    }
}