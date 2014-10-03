public class Ponto{

	public int _x, _y;
	
	public Ponto(int x, int y){
		this._x = x;
		this._y = y;
	}

	public double getModule() {	 
		return Math.sqrt((double)_x*_x + _y*_y);
	}

	public void Print(){
		System.out.println(String.format(
			"SUPER ponto: (x = %d, y = %d)", _x, _y
		));
	}

    public static void main(String [] args) {
        Ponto p = new Ponto(5,7);
		System.out.println(p);
    }
	
	
	@Override
	public String toString(){
		return _x + ", " + _y;
	}
}