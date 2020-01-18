using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Enterprise
    {
        public string name, type_of_property;
        public int workers, registration_day, registration_month, registration_year;
        public float anual_salary;
        public bool leading;

        public int day_of_delivery, month_of_delivery, year_of_delivery, id_of_delivery;
        public float volume_of_delivery, cost_price, profit;

        public List<Product> products;

        public Enterprise()
        {
            int buff;
            //string str_buff;

            Console.WriteLine("Введите название предприятия: ");
            name = Console.ReadLine();

            int caseSwitch = 0;
            Console.WriteLine("Выберите вид собственности:");

            Console.WriteLine("1. Колективная");
            Console.WriteLine("2. Кооперативная");
            Console.WriteLine("3. ООО");
            Console.WriteLine("4. АО");
            Console.WriteLine("5. Трудовая");
            caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    name = "Колективное предприятие " + name;
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    name = "Кооперативное предприятие " + name;
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    name = "ООО " + name;
                    break;
                case 4:
                    Console.WriteLine("Case 4");
                    name = "AO " + name;
                    break;
                case 5:
                    Console.WriteLine("Case 5");
                    name = "Трудовое предприятие " + name;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            Console.WriteLine("Введите день регистрации предприятия: ");
            registration_day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц регистрации предприятия: ");
            registration_month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год регистрации предприятия: ");
            registration_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Является ли передовым(1-да,0-нет): ");
            buff = int.Parse(Console.ReadLine());
            if (buff == 1)
            {
                leading = true;
            }
            else
            {
                leading = false;
            }

            Console.WriteLine("Сколько рабочих на производстве ");
            workers = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько типов продукции имеется: ");
            buff = int.Parse(Console.ReadLine());
            products = new List<Product>(buff);
            for (int i = 0; i < buff; i++)
            {
                products.Add(new Product());
            }

        }

        public Enterprise(string name, int registration_day, int registration_month, int registration_year, bool leading)
        {
            this.name = name;
            this.registration_day = registration_day;
            this.registration_month = registration_month;
            this.registration_year = registration_year;
            this.leading = leading;
        }



        public void Enterprise_info()
        {
            Console.WriteLine("Информация о Компании:");
            Console.WriteLine($"Имя:{name}");
            Console.WriteLine($"Дата регистрации:{registration_day}.{registration_month}.{registration_year}");
            Console.WriteLine($"Количество рабочих:{workers}");
            Console.WriteLine($"Ежегодная выручка: {profit * 12}");
            if (leading == true)
            {
                Console.WriteLine("Является передовым");
            }
            else
            {
                Console.WriteLine("Не является передовым");
            }
            Console.WriteLine("Основной вид продукции");
            if (products != null)
            {
                foreach (Product item in products)
                {
                    if (item.main_product == true)
                    {
                        Console.WriteLine($"id товара-{item.id_of_product}");
                        Console.WriteLine($"Имя- {item.product_name}");

                        if (item.unit_of_measure == true)
                        {
                            Console.WriteLine($"Закупочная цена-{item.buying_price} за кг");
                        }
                        else
                        {
                            Console.WriteLine($"Закупочная цена-{item.buying_price} за м^3");
                        }
                        //Console.WriteLine(item.unit_of_measure);
                    }
                }
            }

            if (products != null)
            {
                foreach (Product item in products)
                {

                    Console.WriteLine("Информация о продукте:");
                    Console.WriteLine($"id товара-{item.id_of_product}");
                    Console.WriteLine($"Имя- {item.product_name}");

                    if (item.unit_of_measure == true)
                    {
                        Console.WriteLine($"Закупочная цена-{item.buying_price} за кг");
                    }
                    else
                    {
                        Console.WriteLine($"Закупочная цена-{item.buying_price} зам ^ 3");
                        
                    }
                    //Console.WriteLine(item.unit_of_measure);
                }
            }

        }

        public void Create_delivery()
        {
            //float buff;

            Console.WriteLine("Форма доставки");

            foreach (Product item in products)
            {

                Console.WriteLine("Информация о продукте:");
                Console.WriteLine($"id товара-{item.id_of_product}");
                Console.WriteLine($"Имя- {item.product_name}");


            }

            Console.WriteLine("Введите id продукта для доставки: ");
            id_of_delivery = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день доставки: ");
            day_of_delivery = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц доставки: ");
            month_of_delivery = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год доставки: ");
            year_of_delivery = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите объём заказа: ");
            volume_of_delivery = int.Parse(Console.ReadLine());

            foreach (Product item in products)
            {

                if (id_of_delivery == item.id_of_product)
                {

                    profit = item.buying_price * volume_of_delivery;
                    break;

                }

            }

        }

    }

    class Product
    {
        public int id_of_product;
        public float buying_price;
        public string product_name;
        public bool unit_of_measure, main_product;

        public Product()
        {
            int buff;
            Console.WriteLine("Введите id продукта: ");
            id_of_product = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите название продукта: ");
            product_name = Console.ReadLine();
            Console.WriteLine("Определите еденицу измерения продукта (1-кг,0-м^3): ");
            // true=кг false=м^3
            buff = int.Parse(Console.ReadLine());
            if (buff == 1)
            {
                unit_of_measure = true;
            }
            else
            {
                unit_of_measure = false;
            }
            Console.WriteLine("Введите закупочную цену продукта: ");
            buying_price = int.Parse(Console.ReadLine());

            Console.WriteLine("Является ли главным продуктом?");
            buff = int.Parse(Console.ReadLine());
            if (buff == 1)
            {
                main_product = true;
            }
            else
            {
                main_product = false;
            }

            
        }

        public Product(int id_of_product, float buying_price, string product_name)
        {
            this.id_of_product = id_of_product;
            this.buying_price = buying_price;
            this.product_name = product_name;
        }



}

    class Delivery
    {
        public int day_of_delivery, month_of_delivery, year_of_delivery;
        public float volume_of_delivery, cost_price, profit;
        //формула стоимости=(себесоимость за еденицу товара(значение задаётся при создании продукта в классе product_create)*объём поставки )
        public void Create()
        {

            Console.WriteLine("Введите id продукта: ");
            day_of_delivery = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день доставки: ");
            day_of_delivery = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц доставки: ");
            month_of_delivery = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год доставки: ");
            year_of_delivery = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите объём заказа: ");
            volume_of_delivery = int.Parse(Console.ReadLine());

        }
    }
    
}