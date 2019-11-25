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
    slovo = strtok(str,razd);//разделяет предложение на слова
	//и убирает ненужные символы
    bool nashel =false;
            while (slovo)//проверяет каждое слово
            {   
                if( slovo[0] == chr)//если первая буква слова равна нужному символу
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

len = strlen(str);//длинна всей строки
int kol=0;
  
  for (int i=0; i < len; i++)
    {
       if (str[i]==' ')//кол-во пробелов в строке
        {
           kol++;
        }
        
    }
    if(kol == len)//если кол-во пробелов равно длине строки,
	          //значит вся строка из пробелов
    {
        cout<<"no";
    }
  
    return 0;
}

