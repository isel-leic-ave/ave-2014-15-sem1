using System;

struct Ponto {

    int x, y;

    public Ponto(int x, int y) {
        this.x = x;
        this.y = y;
    }
}

class Program
{

    static void Main()
    {
        Ponto p = new Ponto(5, 7);

        Type t = p.GetType();
    }
}