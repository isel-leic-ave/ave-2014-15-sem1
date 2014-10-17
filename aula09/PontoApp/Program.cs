using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

interface ISetter
{
    void SetX(int v);
}

struct Ponto : ISetter
{

    public int x, y;

    public Ponto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetX(int v) { 
        this.x = v; 
    }

    public override String ToString() { return String.Format("({0}, {1})", x, y); }
}

class Program
{

    static void Main()
    {
        Ponto p1 = new Ponto(5, 7);

        // p1.SetX(9);

        Ponto p2 = new Ponto();

        Object o = p1; // box


        // ((Ponto)o).x = 11; // => ERRO de COMPILAÇÃO

        Console.WriteLine(o);
        // ((Ponto)o).SetX(11); // Modifica o estado da instancia temporaria que está unboxed
        Console.WriteLine(o);

        ISetter s = (ISetter)o;
        s.SetX(11); // Modifica a instancia referida por o
        Console.WriteLine(o);

    }
}