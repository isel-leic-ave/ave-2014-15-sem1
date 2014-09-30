// PontoApp.cpp : Defines the entry point for the console application.
//

#include "Ponto.h"
#include <iostream>
#include <stdio.h>


int main(int argc, char* argv[])
{
	Ponto* p = new Ponto(5, 7);
	p->Print();
	printf("module = %f\n", p->getModule());
	free(p);
	return 0;
}

