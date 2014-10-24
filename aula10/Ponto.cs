using System;


class Ponto {

    private int _y;

    public Ponto(int x, int y) {
        this.X = x;
        this.Y = y;
    }

    public int X
    {
        get;
        set;
    }
    public int Y
    {
        get { return _y; }
        set { this._y = value; }
    }

    public double Module {
        get {
            return Math.Sqrt(X*X + Y*Y);
        }
    }

    public override String ToString() { return String.Format("({0}, {1})", X, Y); }
}

class Program
{

    static void Main()
    {
        Ponto p1 = new Ponto(5, 7);

       

    }
}