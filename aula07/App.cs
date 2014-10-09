using System;


class A {
    public static void m() { B.m(); }
}

class B
{
    public static void m() { C.m(); D.m(); }
}

class C
{
    public static void m() { }
}

class D
{
    public static void m() { }
}


class Program
{
    static void Main()
    {
        A.m();
        A.m();
    }
}