#include <iostream>
#include <math.h>
using namespace std;




int main()
{	
	void pl(float a,float b,float c,float *y,float *x);
	float a,b,c;
	float y;
	float x;
	cout << "input a,b,c:" << "\n";
	cin >>a >>b >>c ;

	
pl( a,b,c,&y,&x);

	cout << "srednee znachenie: " <<x <<"\n";
	cout << "proizvedenie moduley: " << y;
	return 0;
}

 void pl(float a, float b, float c,float *y,float *x)
{
	*x = (a+b+c)/3;

	*y = abs(a)*abs(b)*abs(c);

}
