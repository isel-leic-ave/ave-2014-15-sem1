using System;


class A
{
    public void Print() { Console.WriteLine("Super A"); }
}

class B : A
{

}

class Program
{
    static void CompatibleWithA(Object o) 
    {
        if (o is A)
        {
            Console.WriteLine("Compativel com A");
        }
        else {
            Console.WriteLine("INCompativel com A");
        }
    }

    static void ExactTypeOfA(Object o) 
    {
        if (o.GetType() == typeof(A))
        {
            Console.WriteLine("É um A");
        }
        else
        {
            Console.WriteLine("NÃO é A");
        }
    }

    static void Dummy(Object o) {
        /* NÃO FAZER */
        /*
        if (o is A)
        {
            A a = (A)o;
            a.Print();
        }
         **/
        A a = o as A;
        if (a != null)
        {
            a.Print();
        }
    
    }

    static void Main()
    {
        CompatibleWithA(new B());
        ExactTypeOfA(new B());
        Dummy(new B());
    }
}