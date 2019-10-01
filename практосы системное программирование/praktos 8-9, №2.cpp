#include <iostream>

using namespace std;



int main()
{	
	int a,b,c;
	float y;
	cout << "input a,b,c:" << "\n";
	cin >>a >>b >>c ;
	int *t = &a;
	int *e = &b;
	int *z = &c;
	y = (*t+*e+*z)/3;




	cout << y;
	return 0;
}


