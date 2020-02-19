using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            string start;
            Console.WriteLine("Начать программу? (да,нет)");
            start = Console.ReadLine();
            if (start == "да")
            {
                Console.WriteLine("Информация о сборке ");
                Sborka PK = new Sborka();
                Console.WriteLine("Информация о реализации ");
                reliz prod = new reliz();


                string a;

                Console.WriteLine("Вывсти информация о партии пк(да,нет): ");
                a = Console.ReadLine();
                if (a == "да")
                {
                    PK.Sborka_info();
                    prod.reliz_info();
                    //firm.info();
                    //firm1.ralizator_info();
                    Console.WriteLine("Программа завершена");
                }
            }
            else
            {
                Console.WriteLine("Программа завершена");
            }
        }
    }

    class izgotov
    {

        public string name, phone, place;

        public izgotov()
        {

            Console.WriteLine("\nВведите название Фирмы изготовителя: ");
            name = Console.ReadLine();

            Console.WriteLine("\nВведите телефон Фирмы изготовителя: ");
            phone = Console.ReadLine();

            Console.WriteLine("\nВведите место размещения фирмы Фирмы изготовителя: ");
            place = Console.ReadLine();

        }

        public izgotov(string name, string phone, string place)
        {
            this.name = name;
            this.phone = phone;
            this.place = place;
        }

        public void info()
        {
            Console.WriteLine("\nИнформация о Фирме изготовителе");
            Console.WriteLine($"\nНазвание: {name}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"место размещения фирмы Фирмы изготовителя: {place}");
        }

    }
    class ralizator
    {
        public string name_reliz, phone_reliz, place_reliz;

        public ralizator()
        {
            Console.WriteLine("\nВведите название Фирмы реализатора: ");
            name_reliz = Console.ReadLine();

            Console.WriteLine("\nВведите телефон Фирмы реализатора: ");
            phone_reliz = Console.ReadLine();

            Console.WriteLine("\nВведите место размещения фирмы Фирмы реализатора: ");
            place_reliz = Console.ReadLine();


        }
        public ralizator(string name_reliz, string phone_reliz)
        {
            this.name_reliz = name_reliz;
            this.phone_reliz = phone_reliz;



        }
        public void ralizator_info()
        {
            Console.WriteLine("\nИнформация о Фирме реализаторе");
            Console.WriteLine($"\nНазвание: {name_reliz}");
            Console.WriteLine($"Телефон: {phone_reliz}");
            Console.WriteLine($"место размещения фирмы Фирмы реализатора: {place_reliz}");

        }
    }

    class Sborka
    {
        public izgotov izg;
        izgotov firm = new izgotov();
        public string cpu, cpu_ghz;
        int ram, hdd;
        public int relise_day, relise_month, relise_year;
       
        public Sborka()
        {
            
            int tip_cpu = 0;
            Console.WriteLine("\nВыберите тип процессора: ");

            Console.WriteLine("1. Ryzen");
            Console.WriteLine("2. Cor i");
            Console.WriteLine("3. Pentium");
            Console.WriteLine("4. Celeron");
            Console.WriteLine("5. Athlon");
            tip_cpu = int.Parse(Console.ReadLine());

            switch (tip_cpu)
            {
                case 1:
                    Console.WriteLine("Выбран Ryzen");
                    cpu = "Ryzen ";
                    break;
                case 2:
                    Console.WriteLine("Выбран Cor i");
                    cpu = "Cor i ";
                    break;
                case 3:
                    Console.WriteLine("Выбран Pentium");
                    cpu = "Pentium ";
                    break;
                case 4:
                    Console.WriteLine("Выбран Celeron");
                    cpu = "Celeron ";
                    break;
                case 5:
                    Console.WriteLine("Выбран Athlon");
                    cpu = "Athlon ";
                    break;
                default:
                    Console.WriteLine("Некоректный ввод");
                    break;
            }
            int cpu_ghz_int = 0;
            Console.WriteLine("\nВыберите частоту процессора: ");
            Console.WriteLine("1. 3.0");
            Console.WriteLine("2. 3.5");
            Console.WriteLine("3. 4.0");
            Console.WriteLine("4. 2.6");
            Console.WriteLine("5. 4.5");
            cpu_ghz_int = int.Parse(Console.ReadLine());
                switch (cpu_ghz_int)
                {
                case 1:
                    Console.WriteLine("Выбрана частота 3.0");
                    cpu_ghz = "3.0 ";
                    break;
                case 2:
                    Console.WriteLine("Выбрана частота 3.5");
                    cpu_ghz = "3.5 ";
                    break;
                case 3:
                    Console.WriteLine("Выбрана частота 4.0");
                    cpu_ghz = "4.0 ";
                    break;
                case 4:
                    Console.WriteLine("Выбрана частота 2.6");
                    cpu_ghz = "2.6 ";
                    break;
                case 5:
                    Console.WriteLine("Выбрана частота 4.5");
                    cpu_ghz = "4.5 ";
                    break;
                default:
                    Console.WriteLine("Некоректный ввод");
                    break;
                }
            
            Console.WriteLine("\nВведите кол-во ОЗУ(в гигабайтах): ");
            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите объем жесткого диска(в гигабайтах): ");
            hdd = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день выпуска: ");
            relise_day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц выпуска: ");
            relise_month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год выпуска: ");
            relise_year = int.Parse(Console.ReadLine());
        }

        public Sborka(int ram, int hdd, string cpu, string cpu_ghz, int relise_day, int relise_month, int relise_year)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
            this.cpu_ghz = cpu_ghz;

            this.relise_day = relise_day;
            this.relise_month = relise_month;
            this.relise_year = relise_year;
        }
        public void Sborka_info()
        {
            Console.WriteLine("\nИнформация о Сборке");
            Console.WriteLine($"\nНазвание процессора: {cpu}");
            Console.WriteLine($"частота процессора: {cpu_ghz}");
            Console.WriteLine($"объем оперативной памяти(в гигабайтах): {ram}");
            Console.WriteLine($"объем жесткого диска(в гигабайтах): {hdd}");
            Console.WriteLine($"Дата выпуска: {relise_day}. {relise_month}. {relise_year}");
            firm.info();
        }

    }

    class reliz
    {
        public ralizator realis;
        ralizator firm1 = new ralizator();//надо  вписать реализатора
        public int V;//объем
        public Sborka sborka;
        public float price;
        public int relise_day, relise_month, relise_year;
        public reliz()
        {

            Console.WriteLine("\nВведите объем партии: ");
            V = int.Parse(Console.ReadLine());


            price = V * 5000;
            Console.WriteLine("\nцена партии: " + price);

            Console.WriteLine("\nВведите день реализации: ");
            relise_day = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите месяц реализации: ");
            relise_month = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите год реализации: ");
            relise_year = int.Parse(Console.ReadLine());

        }
        public reliz(Sborka sborka, int v, float price, int relise_day1, int relise_month1, int relise_year1)
        {
            this.V = v;
            this.price = price;
            this.sborka = sborka;

            this.relise_day = relise_day1;
            this.relise_month = relise_month1;
            this.relise_year = relise_year1;
        }

        public void reliz_info()
        {
            Console.WriteLine("\nИнформация о реализации");
            Console.WriteLine($"\nцена партии: {price}");
            Console.WriteLine($"объем партии: {V}");
            Console.WriteLine($"Дата реализации: {relise_day}. {relise_month}. {relise_year}");
            firm1.ralizator_info();
        }
    }
}
