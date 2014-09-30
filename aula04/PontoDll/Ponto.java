
class Ponto{

	int _x, _y;
	
	public Ponto(int x, int y){
		this._x = x;
		this._y = y;
	}

	public double getModule() {	 
		return Math.sqrt((double)_x*_x + _y*_y);
	}

	public void Print(){
		System.out.println(
			String.format(
				"SUPER ponto: (x = %d, y = %d)\n", _x, _y
		));
	}
}