
class A
{
    public void Print() { }
}

class B extends A
{

}

class Program
{
    static void Dummy(Object o) {
        if (o instanceof A)
        {
            A a = (A)o;
            a.Print();
        }
    
    }

    static void Main()
    {
        Dummy(new B());
    }
}