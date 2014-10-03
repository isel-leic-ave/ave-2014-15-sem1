using System;

class Ponto{

	public int _x, _y;
	
	public Ponto(int x, int y){
		this._x = x;
		this._y = y;
	}

	public double getModule() {	 
		return Math.Sqrt((double)_x*_x + _y*_y);
	}

	public void Print(){
		Console.WriteLine(
			"SUPER ponto: (x = {0}, y = {1})\n", _x, _y
		);
	}

    public override String ToString() {
        return _x + ", " + _y;
    }
}

class Person{

    void Dummy(){}
}

class App
{
    static void Print(Object o) {
        Console.WriteLine(o);
    }

    static void Main()
    {
        Ponto p = new Ponto(5, 7);
        Print(p);
        Print(new Person());
    }

}