using System;

interface ISetter {
    void SetX(int v);
}

struct Ponto : ISetter{

    public int x, y;

    public Ponto(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void SetX(int v) { this.x = v; }

    public override String ToString() { return String.Format("({0}, {1})", x, y); }
}

class Program
{

    static void Main()
    {
        Ponto p1 = new Ponto(5, 7);

        Ponto p2 = new Ponto();

        Object o = p1; // box


        // ((Ponto)o).x = 11; // => ERRO de COMPILA��O

        Console.WriteLine(o);
        ((Ponto)o).SetX(11); // Modifica o estado da instancia temporaria que est� unboxed
        Console.WriteLine(o);

        ((ISetter)o).SetX(11); // Modifica a instancia referida por o
        Console.WriteLine(o);

    }
}