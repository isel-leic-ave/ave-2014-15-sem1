using System;

class A { }
class B:A { }
class C:B { }

class X { }
class Y : X { }
class Z : Y { }


class Program
{
    static A makeA() { return new B(); }

    static X makeX() { return new Y(); }


    static void Main()
    {
        A a = makeA();
        // C c =  a; // Erro de compila��o
        C c = (C) a; // casting explicito => castclass
        B b = c; // casting impl�cito => nada

        X x = makeX();
        B b2 = (B) x;

    }
}