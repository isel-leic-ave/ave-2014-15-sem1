using System;

public class PontoApp{

	static void  Main()
	{
		Ponto p = new Ponto(5, 7);
		p.Print();
        p._x = 9;
		Console.WriteLine("p._x = {0}\n", p._x);
	}

}