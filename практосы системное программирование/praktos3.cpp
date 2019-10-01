#include <iostream>
using namespace std;
int main()
{
	int x;
	
	cout << "enter the area code: ";
	cin >> x;
	switch(x){
	case 8622:
		cout << "Adler";
		break;
	case 8632:	
		cout << "Rostov";
		break;
	case 3532:	
		cout << "Orenburg";
		break;
	case 8162:	
		cout << "Novgorod";
		break;
	case 812:	
		cout << "Sankt-Peterburg";
		break;
	case 3812:	
		cout << "Omsk";
		break;
	case 8623:
		cout << "Sochi";
		break;
	default:
		cout << "no";
		break;
	
	}
}
