class A { }
class B extends A { }
class C extends B { }

class X { }
class Y  extends  X { }
class Z  extends  Y { }


class Program
{
    static A makeA() { return new B(); }

    static X makeX() { return new Y(); }


    static void Main()
    {
        A a = makeA();
        // C c =  a; // Erro de compilação
        C c = (C) a; // casting explicito => castclass
        B b = c; // casting implícito => nada

        X x = makeX();
        B b2 = (B) x;

    }
}