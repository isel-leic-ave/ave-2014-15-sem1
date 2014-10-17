using System;

interface I { void m();}

class A : I { 
    public void m(){
        Console.WriteLine("I'm A");
    }
}

class B : A, I
{
    public new void m()
    {
        Console.WriteLine("I'm B");
    }
}

class C : I {
    void I.m() {
        Console.WriteLine("I'm C");
    }
}

class D : C, I {
    public void m()
    {
        Console.WriteLine("I'm D");
    }

}

class Program
{

    static void Main()
    {

        C c = new C();
        I i = c;
        i.m();

        B b = new B();
        A a = b;
        i = b;

        a.m();
        b.m();
        i.m();

    }
}