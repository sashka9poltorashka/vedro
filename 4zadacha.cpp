#include <iostream>
#include <math.h>
#include <string>

using namespace std;

class factorial
{
  public:
    int n;

factorial();
factorialFunc(int n);
void factorialInfo();
};

factorial::factorial()
{  
  cout<<"input n: ";
  cin>>n;
}

int factorial::factorialFunc(int n) 
{
  int res = 1;
  for (int i = 1; i <= n; i++)
  {
	  res = res * i;
  }
  return res;
}

void factorial::factorialInfo() 
{
  cout<< "n = "<<n << endl;
  cout<< "n! = " <<factorialFunc(n);
}


int main()
{
  factorial s1;
  s1.factorialInfo();
}