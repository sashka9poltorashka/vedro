#include <iostream>
#include <math.h>
#include <conio.h>

using namespace std;

int main()
{

int input;
float y, x;
cout << "enter the number of the equation:" << "\n";
cin >> input;
switch(input){
case 1: {
	cout << "Enter x" << "\n";
	cin >> x;
	y = (x<=6) ? x : (x>6) ? 4 / x *(x+1): false; 
	cout << y;  
    }
    
case 2:{
	cout << "Enter x" << "\n";
    cin >> x; 
    y = (x < 1) ? x+1 : (1 <= x && x <= 2) ? sqrt(2+x):(x>2)?4*x:false;
    cout << y;
    }
}
return 0;
} 
