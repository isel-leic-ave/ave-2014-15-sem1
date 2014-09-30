// Ponto.cpp : Defines the exported functions by Ponto.dll
//

#include "Ponto.h"
#include <math.h>
#include <iostream>

/*
 * This is the constructor of a class that has been exported.
 * see Ponto.h for the class definition
 */
Ponto::Ponto(int x, int y){
	this->_x = x;
	this->_y = y;
	this->_z = 0;
}

double Ponto::getModule() {	 
	return sqrt((double)_x*_x + _y*_y + _z*_z);
}

void Ponto::Print(){
	printf("SUPER: (x = %d, y = %d, z=%d)\n", _x, _y, _z);
}

