// aula09-tpc.cpp : main project file.

#include "stdafx.h"
#include <stdio.h> 

using namespace System;

/*
* a value type
*/
value struct Ponto{

public:
	int x, y;

	Ponto(int x, int y){
		this->x = x;
		this->y = y;
	}
	int Print() {
		return printf("(%d, %d)\n", x, y);
	}

};

/*
* unmanaged pointer
*/
void SetYonVTPoint(Ponto* o, int v){
	o->y = v;
};

/*
* reference to the managed heap
*/
void SetYonRTPoint(Ponto^ o, int v){
	o->y = v;
};

void main() {
	Ponto p2 = Ponto(5, 7);
	SetYonVTPoint(&p2, 11);
	p2.Print();

	Ponto^ p1 = gcnew Ponto(5, 7);
	SetYonRTPoint(p1, 17);
	p1->Print();

};