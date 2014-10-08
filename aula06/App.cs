

public class Base
{
    public virtual void DoItForReal() { }
    public void DoIt() { }
}

public class Derived1 : Base
{
    public override void DoItForReal()
    {
        base.DoItForReal();
    }
}

public class Derived2 : Base
{
    public override void DoItForReal()
    {
        base.DoItForReal(); 
    }
}

class App {
    static void Main() {
        Base b = null;
        b.DoIt(); //callvirt (despacho estatico, pq o método é NAO virtual)
        b.DoItForReal();  //callvirt (despacho dinamico, pq o método é virtual)
    }
}