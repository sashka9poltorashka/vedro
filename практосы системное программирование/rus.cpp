#include <iostream>
#include <stdio.h>
using namespace std;
#include <cstring>
int main()
{
	//setlocale(LC_ALL, "Rus");
	
    char *slovo,str[100], chr;
    int len;
    cout<<"imput text: ";
    gets(str);// ввод текста
	cout<<"imput simvol: ";
    cin >> chr;// символ  
    char *razd = " ,.";
    slovo = strtok(str,razd);
    bool nashel =false;
            while (slovo)
            {   
                if( slovo[0] == chr)
                {
                nashel = true;
                cout << slovo;
                cout << '\t';
                }
                
                slovo = strtok(NULL, razd);
            }

            if(nashel == false)
                {
                cout << "net takogo slova";
                }
            cout << '\n';

len = strlen(str);
int kol=0;
  
  for (int i=0; i < len; i++)
    {
       if (str[i]==' ')
        {
           kol++;
        }
        
    }
    if(kol == len)
    {
        cout<<"no";
    }
  
    return 0;
}

