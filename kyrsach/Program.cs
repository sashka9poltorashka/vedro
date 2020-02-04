using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Programm {
        static void Main(string[] args)
        {
            Sborka PK = new Sborka();
            izgotov firm = new izgotov();
            ralizator firm1 = new ralizator();
            reliz prod = new reliz();

            Console.WriteLine("");
            Console.ReadLine();


        }


    }

    class izgotov
    {

        public string name, phone, place;

        public izgotov()
        {

            Console.WriteLine("Введите название Фирмы изготовителя: ");
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
            Console.WriteLine("\nИнформация о Фирме изготовителе:\n");
            Console.WriteLine($"\nНазвание: {name}");
            Console.WriteLine($"\nТелефон: {phone}");
            Console.WriteLine($"\nместо размещения фирмы Фирмы изготовителя: {place}");
        }

    }
    class ralizator
    {
        public string name_reliz, phone_reliz, place_reliz;
        reliz[] relizes;
        Sborka[] sborkas;
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
            Console.WriteLine("\nИнформация о Фирме реализаторе:");
            Console.WriteLine($"\nНазвание: {name_reliz}");
            Console.WriteLine($"\nТелефон: {phone_reliz}");
            Console.WriteLine($"\nместо размещения фирмы Фирмы реализатора: {place_reliz}");

        }
    }




    class Sborka
    {
        public string cpu, cpu_ghz;
        int ram, hdd;
        public int relise_day, relise_month, relise_year;
        izgotov prod;
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
                    Console.WriteLine("Case 1");
                    cpu = "Ryzen ";
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    cpu = "Cor i ";
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    cpu = "Pentium ";
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    cpu = "Celeron ";
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    cpu = "Athlon ";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            int ghz_cpu = 0;
            Console.WriteLine("\nВыберите тип процессора: ");

            Console.WriteLine("1. 3.0");
            Console.WriteLine("2. 3.5");
            Console.WriteLine("3. 4.0");
            Console.WriteLine("4. 2.6");
            Console.WriteLine("5. 999");
            tip_cpu = int.Parse(Console.ReadLine());

            switch (ghz_cpu)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    cpu_ghz = "3.0 ";
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    cpu_ghz = "3.5 ";
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    cpu_ghz = "4.0 ";
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    cpu_ghz = "2.6 ";
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    cpu_ghz = "999 ";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }



            Console.WriteLine("\nВведите кол-во ОЗУ(в гигабайтах): ");
            ram = int.Parse(Console.ReadLine());



            int hdd;
            Console.WriteLine("\nВведите объем жесткого диска(в гигабайтах): ");
            hdd = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите день выпуска: ");
            relise_day = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите месяц выпуска: ");
            relise_month = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите год выпуска: ");
            relise_year = int.Parse(Console.ReadLine());
        }

        public Sborka(int ram, int hdd, string cpu, int relise_day, int relise_month, int relise_year)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;

            this.relise_day = relise_day;
            this.relise_month = relise_month;
            this.relise_year = relise_year;
        }
        public void Sborka_info()
        {
            Console.WriteLine("\nИнформация о Сборке:\n");
            Console.WriteLine($"\nНазвание процессора: {cpu}");
            Console.WriteLine($"\nчастота процессора: {cpu_ghz}");
            Console.WriteLine($"\nобъем оперативной памяти(в гигабайтах): {ram}");
            Console.WriteLine($"\nобъем оперативной жесткого диска(в гигабайтах): {hdd}");
            Console.WriteLine($"\nДата выпуска: {relise_day}");
            Console.WriteLine($". {relise_month}");
            Console.WriteLine($". {relise_year}");

        }


    }

    class reliz
    {
        public int V;
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
            Console.WriteLine("\nИнформация о реализации:");
            Console.WriteLine($"\nцена партии: {price}");
            Console.WriteLine($"\nобъем партии: {V}");

            Console.WriteLine($"\nДата реализации: {relise_day}");
            Console.WriteLine($". {relise_month}");
            Console.WriteLine($". {relise_year}");

        }






    }
}
