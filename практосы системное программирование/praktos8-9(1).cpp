#include <iostream>

using namespace std;

float pl(float x, float y);

int main()
{	
	float a,b,P;
	cout << "input a: ";
	cin >>a;
	cout << "input b: ";
	cin >> b;
	
	if (a <=0 || b <=0){
	cout << "not valid valuens";
		return 0;
	}
	
	
	P=pl(a,b);
	cout << P;
	return 0;
}

float pl(float x,float y)
{
	float P;
	P = 2*(x+y);
	return P;
}
