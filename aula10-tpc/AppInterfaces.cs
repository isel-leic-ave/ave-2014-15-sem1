using System;

interface I { void m();}

class A : I { 
    public virtual void m(){
        Console.WriteLine("I'm A");
    }
}

class B : A
{
    public sealed override void m()
    {
        Console.WriteLine("I'm B");
    }
}

class C : B, I {
    public new virtual void m() {
        Console.WriteLine("I'm C");
    }
}

class D : C{
    public override void m()
    {
        Console.WriteLine("I'm D");
    }

}

class Program
{
    static void Main()
    {

        D d = new D();
        I i = d;

        A a = d;
        B b = d;
        C c = d;

        a.m();
        b.m();
        c.m();
        i.m();
    }
}