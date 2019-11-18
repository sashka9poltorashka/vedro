#include <iostream>
#include <stdio.h>
using namespace std;
#include <cstring>

/*Составить программу, в которой описывается структура из полей: Товар, Цена поставщика, Процент наценки.
 Организовать ввод двух структурных переменных, вывод каждой структуры на экран и расчет значения "Цена розничная".
Цена розничная = Цена поставщика + Цена поставщика * Процент наценки/100.*/
struct Nakladnay
{
    char tovar[30];
    int price; 
    int nacenk;
};

//Nakladnay prod[30];

void vvod(Nakladnay *m1)
{
    
    cout << "\ntovar: ";
    gets(m1->tovar);		// Ввод названия товара 
    cout <<"price: ";
    cin >> m1->price;		// Ввод цены поставщика
    cout<<"nacenk %: ";
    cin >> m1->nacenk;		// Ввод наценки

}

void vivod (Nakladnay m)
{
    cout <<"\ntovar: " << m.tovar;
    cout <<"\nprice: " << m.price;
    cout <<"\nnacenk: " << m.nacenk;
}

int main()
{
Nakladnay c1,c2;	//две структуры


cout << "\ninform 1 tovar: ";
vvod(&c1);	// Ввод первой структуры, в функцию vvod передается адрес структуры c1
cin.clear();
fflush(stdin);
cout << "\ninform 2 tovar: ";
vvod(&c2);	// Ввод второй структуры, в функцию vvod передается адрес структуры c2

/* Вывод результатов */
vivod(c1);	// Вывод первой структуры с1 – сведения о первом товаре
cout << "\nitog price 1: "<< c1.price + (c1.price/100)*c1.nacenk<< endl;
vivod(c2);	// Вывод второй структуры с2 – сведения о втором товаре
cout << "\nitog  price 2: "<< c2.price + (c2.price/100)*c2.nacenk;

}