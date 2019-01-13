using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Storage_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Adress adress = new Adress("Украина", "Днепр", "Кирова", "46");

            Table table = new Table("барный", "квадратный", 1.5, 1.3, "дсп + дерево", "дсп", "белый", "IKEA", "Польша", 1450);
            Table table2 = new Table("обеденный", "прямоугольный", 1.45, 1.4, "дерево", "закаленное стекло", "бордовый", "ВIКА", "Украина", 2300);
            Table table3 = new Table("обеденный", "круглый", 1.33, 1.5, "закаленное стекло", "мдф + дерево", "коричневый", "MatroLuxe", "Украина", 7100);

            Сhair chair = new Сhair("скамья", "кухонный", "изогнутая", "прямые", "металл", "велюр", "фиолетовый", "Camelia", "Польша", 950);
            Сhair chair2 = new Сhair("табурет", "декоративный", "нет", "прямые", "дерево", "вельвет", "зеленый", "Bellini", "Италия", 720);
            Сhair chair3 = new Сhair("стул", "кухонный", "прямая", "изогнутые", "металл", "кожзам", "красный", "Signal", "Малайзия", 450);
            Сhair chair4 = new Сhair("стул", "кухонный", "прямая", "прямые", "дерево + металл", "экокожа", "желтый", "Domoni", "Италия", 880);

            Armchair armchair = new Armchair("кресло", "нераскладные", 1.6, 1.1, "велюр", "черный", "MatroLuxe", "Украина", 2400);
            Armchair armchair2 = new Armchair("кресло-качалка", "нераскладные", 1.45, 1.4, "вельвет", "синий", "IKEA", "Польша", 3100);

            Sofa sofa = new Sofa("прямой", "нераскладные", "еврокнижка", 2.2, "текстиль", "бежевый", "MatroLuxe", "Украина", 9900);
            Sofa sofa2 = new Sofa("угловой", "раскладные", "седафлекс", 2.8, "экокожа", "оранжевый", "Bellini", "Италия", 12700);
            Sofa sofa3 = new Sofa("офисный", "нераскладные", "нет", 1.8, "кожа", "черный", "Bellini", "Италия", 15800);

            Bed bed = new Bed("односпальная", 190, 110, "брус", "текстиль", "дерево + мдф", "черный", "MatroLuxe", "Украина", 6450);
            Bed bed2 = new Bed("двуспальная", 200, 200, "ламели", "искусственная кожа", "дерево", "коралловый", "Bellini", "Италия", 15900);
            Bed bed3 = new Bed("полуторная", 190, 140, "нет", "ткань", "лдсп", "белый", "IKEA", "Польша", 7300);

            Cupboard cupboard = new Cupboard("шкаф-купе", 2, 2.44, 2.2, "зеркало с рисунком", "ламинированная дсп", "синий", "MatroLuxe", "Украина", 11500);
            Cupboard cupboard2 = new Cupboard("книжный", 4, 1.95, 1.5, "матовое стекло", "дерево", "коричневый", "MatroLuxe", "Украина", 7900);

            Storage storage = new Storage(adress);
            AddFurnitureInStorage(storage, table, table2, table3, chair, chair2, chair3, chair4, armchair, armchair2, sofa, sofa2, sofa3, bed, bed2, bed3, cupboard, cupboard2);
            */
                       
            Menu();
        }

        static void AddFurnitureInStorage(Storage storage, params Furniture[] furnitures)
        {
            for (int i = 0; i < furnitures.Length; i++)
                storage.AddFurniture(furnitures[i]);
        }

        static void Menu()
        {
            Console.WriteLine("Введите адрес склада:");
            Storage storage = new Storage(CreateAdress());
            Console.Clear();
            int action, choice;
            double price;

            do
            {
                Console.WriteLine("МЕНЮ:\n[1] добавить мебель");
                Console.WriteLine("[2] удалить мебель");
                Console.WriteLine("[3] вывод информации о конкретной мебели по индексу товара");
                Console.WriteLine("[4] вывод информации о конкретной категории мебели");
                Console.WriteLine("[5] изменить цену конкретной мебели");
                Console.WriteLine("[6] вывод товаров всего склада");
                Console.WriteLine("[7] узнать количество товаров всего склада");
                Console.WriteLine("[8] узнать количество товаров конкретной категории");
                Console.WriteLine("[9] посмотреть адрес склада");
                Console.WriteLine("[0] выход");
                Console.Write("\nВыберите действие: ");
                int.TryParse(Console.ReadLine(), out action);
                Console.Clear();

                if (action == 1)
                {
                    Console.WriteLine("Какой вид мебели вы хотите добавить:\n[1] стол\n[2] стул\n[3] кресло\n[4] диван\n[5] кровать\n[6] шкаф");
                    int.TryParse(Console.ReadLine(), out choice);

                    if (choice == 1)
                        storage.AddFurniture(CreateTable());
                    else if (choice == 2)
                        storage.AddFurniture(CreateChair());
                    else if (choice == 3)
                        storage.AddFurniture(CreateArmchair());
                    else if (choice == 4)
                        storage.AddFurniture(CreateSofa());
                    else if (choice == 5)
                        storage.AddFurniture(CreateBed());
                    else if (choice == 6)
                        storage.AddFurniture(CreateCupboard());
                    else
                        Console.WriteLine("Error!!!");
                }
                else if(action == 2)
                {
                    Console.WriteLine("Какой вид мебели вы хотите удалить?\n[1] стол\n[2] стул\n[3] кресло\n[4] диван\n[5] кровать\n[6] шкаф");
                    int.TryParse(Console.ReadLine(), out choice);
                    Console.WriteLine("\nВведите данные удаляемой мебели: ");

                    if (choice == 1)
                        storage.RemoveFurniture(CreateTable());
                    else if (choice == 2)
                        storage.RemoveFurniture(CreateChair());
                    else if (choice == 3)
                        storage.RemoveFurniture(CreateArmchair());
                    else if (choice == 4)
                        storage.RemoveFurniture(CreateSofa());
                    else if (choice == 5)
                        storage.RemoveFurniture(CreateBed());
                    else if (choice == 6)
                        storage.RemoveFurniture(CreateCupboard());
                    else
                        Console.WriteLine("Мебели с такими характеристиками в базе не существует!");
                }
                else if(action == 3)
                {
                    Console.WriteLine("Информацию о каком виде мебели вы хотите посмотреть?\n[1] стол\n[2] стул\n[3] кресло\n[4] диван\n[5] кровать\n[6] шкаф");
                    int.TryParse(Console.ReadLine(), out choice);
                    Console.Write("Введите индекс товара: ");
                    int idx;
                    int.TryParse(Console.ReadLine(), out idx);

                    if (choice == 1)
                        Console.WriteLine(storage.GetInfoByIndex(new Table(), idx));
                    else if (choice == 2)
                        Console.WriteLine(storage.GetInfoByIndex(new Сhair(), idx));
                    else if (choice == 3)
                        Console.WriteLine(storage.GetInfoByIndex(new Armchair(), idx));
                    else if (choice == 4)
                        Console.WriteLine(storage.GetInfoByIndex(new Sofa(), idx));
                    else if (choice == 5)
                        Console.WriteLine(storage.GetInfoByIndex(new Bed(), idx));
                    else if (choice == 6)
                        Console.WriteLine(storage.GetInfoByIndex(new Cupboard(), idx));
                    else
                        Console.WriteLine("Мебели данного типа в базе не существует!");
                    Thread.Sleep(3000);
                }
                else if(action == 4)
                {
                    Console.WriteLine("Информацию какой категории мебели вы хотите посмотреть?\n[1] стол\n[2] стул\n[3] кресло\n[4] диван\n[5] кровать\n[6] шкаф");
                    int.TryParse(Console.ReadLine(), out choice);

                    if (choice == 1)
                        Console.WriteLine(storage.GetInfoAboutAllCategoryOf(new Table().GetType()));
                    else if (choice == 2)
                        Console.WriteLine(storage.GetInfoAboutAllCategoryOf(new Сhair().GetType()));
                    else if (choice == 3)
                        Console.WriteLine(storage.GetInfoAboutAllCategoryOf(new Armchair().GetType()));
                    else if (choice == 4)
                        Console.WriteLine(storage.GetInfoAboutAllCategoryOf(new Sofa().GetType()));
                    else if (choice == 5)
                        Console.WriteLine(storage.GetInfoAboutAllCategoryOf(new Bed().GetType()));
                    else if (choice == 6)
                        Console.WriteLine(storage.GetInfoAboutAllCategoryOf(new Cupboard().GetType()));
                    else
                        Console.WriteLine("Мебели данного типа в базе не существует!");
                    Thread.Sleep(3000);
                }
                else if(action == 5)
                {
                    Console.WriteLine("В какой категории мебели вы хотите изменить цену?\n[1] стол\n[2] стул\n[3] кресло\n[4] диван\n[5] кровать\n[6] шкаф");
                    int.TryParse(Console.ReadLine(), out choice);
                    Console.Write("\nВведите новую цену: ");
                    double.TryParse(Console.ReadLine(), out price);
                    Console.WriteLine("Введите текущие данные мебели: ");

                    if (choice == 1)
                        storage.ChangePrice(CreateTable(), price);
                    else if (choice == 2)
                        storage.RemoveFurniture(CreateChair());
                    else if (choice == 3)
                        storage.RemoveFurniture(CreateArmchair());
                    else if (choice == 4)
                        storage.RemoveFurniture(CreateSofa());
                    else if (choice == 5)
                        storage.RemoveFurniture(CreateBed());
                    else if (choice == 6)
                        storage.RemoveFurniture(CreateCupboard());
                    else
                        Console.WriteLine("Мебели с такими характеристиками в базе не существует!");
                    Thread.Sleep(1500);
                }
                else if(action == 6)
                {
                    Console.WriteLine("* * * * * СКЛАД МЕБЕЛИ * * * * *\n{0}", storage.GetInfoAllStorage());
                    Thread.Sleep(4000);
                }
                else if(action == 7)
                {
                    Console.WriteLine("Количество товаров нa сладе: {0}", storage.GetCountAllFurniture());
                    Thread.Sleep(2000);
                }
                else if(action == 8)
                {
                    Console.WriteLine("Выберите категорию:\n[1] стол\n[2] стул\n[3] кресло\n[4] диван\n[5] кровать\n[6] шкаф");
                    int.TryParse(Console.ReadLine(), out choice);

                    if (choice == 1)
                        Console.WriteLine("Количество товаров категории \"Стол\" = {0}", storage.GetCountFurnitureOfType(new Table().GetType()));
                    else if (choice == 2)
                        Console.WriteLine("Количество товаров категории \"Стул\" = {0}", storage.GetCountFurnitureOfType(new Сhair().GetType()));
                    else if (choice == 3)
                        Console.WriteLine("Количество товаров категории \"Кресло\" = {0}", storage.GetCountFurnitureOfType(new Armchair().GetType()));
                    else if (choice == 4)
                        Console.WriteLine("Количество товаров категории \"Диван\" = {0}", storage.GetCountFurnitureOfType(new Sofa().GetType()));
                    else if (choice == 5)
                        Console.WriteLine("Количество товаров категории \"Кровать\" = {0}", storage.GetCountFurnitureOfType(new Bed().GetType()));
                    else if (choice == 6)
                        Console.WriteLine("Количество товаров категории \"Шкаф\" = {0}", storage.GetCountFurnitureOfType(new Cupboard().GetType()));
                    else
                        Console.WriteLine("Error!!!");
                    Thread.Sleep(2000);
                }
                else if(action == 9)
                {
                    Console.WriteLine("Адрес склада:\n{0}", storage.GetAdress());
                    Thread.Sleep(2000);
                }
                else
                {
                    Environment.Exit(0);
                }
                Console.Clear();                 
            } while (action != 0);
        }

        static Adress CreateAdress()
        {
            Adress adress = new Adress();
            int val;
            Console.Write("Страна: ");
            adress.Country = Console.ReadLine();
            Console.Write("Город: ");
            adress.City = Console.ReadLine();
            Console.Write("Улица: ");
            adress.Street = Console.ReadLine();
            Console.Write("Номер дома: ");
            adress.NumberBuild = Console.ReadLine();
            Console.Write("Номер квартиры (если нет - поставьте 0): ");
            int.TryParse(Console.ReadLine(), out val);
            adress.NumberFlat = val;
            return adress;
        }

        static Table CreateTable()
        {
            Table table = new Table();
            double val;
            Console.Write("\nВид (барный, обеденный): ");
            table.Kind = Console.ReadLine();
            Console.Write("Форма: ");
            table.Shape = Console.ReadLine();
            Console.Write("Высота: ");
            double.TryParse(Console.ReadLine(), out val);
            table.Height = val;
            Console.Write("Ширина: ");
            double.TryParse(Console.ReadLine(), out val);
            table.Width = val;
            Console.Write("Материал столешницы: ");
            table.MaterialOfTableTop = Console.ReadLine();
            Console.Write("Материал корпуса: ");
            table.MaterialOfTableTop = Console.ReadLine();
            Console.Write("Цвет: ");
            table.Color = Console.ReadLine();
            Console.Write("Производитель: ");
            table.Manufacturer = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            table.ProducingCountry = Console.ReadLine();
            Console.Write("Цена: ");
            double.TryParse(Console.ReadLine(), out val);
            table.Price = val;
            return table;           
        }

        static Сhair CreateChair()
        {    
            Сhair chair = new Сhair();
            double val;
            Console.Write("\nТип стула (скамья, табурет, стул): ");
            chair.TypeOfChair = Console.ReadLine();
            Console.Write("Вид стула (барный, кухонный, декоративный): ");
            chair.Kind = Console.ReadLine();
            Console.Write("Спинка (изогнутая, прямая): ");
            chair.BackOfChair = Console.ReadLine();
            Console.Write("Ножки (прямые, изогнутые, на колесиках): ");
            chair.Legs = Console.ReadLine();
            Console.Write("Материал каркаса: ");
            chair.MaterialOfFrame = Console.ReadLine();
            Console.Write("Материал обивки: ");
            chair.MaterialOfUpholstery = Console.ReadLine();
            Console.Write("Цвет: ");
            chair.Color = Console.ReadLine();
            Console.Write("Производитель: ");
            chair.Manufacturer = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            chair.ProducingCountry = Console.ReadLine();
            Console.Write("Цена: ");
            double.TryParse(Console.ReadLine(), out val);
            chair.Price = val;
            return chair;
        }

        static Armchair CreateArmchair()
        {
            Armchair armchair = new Armchair();
            double val;
            Console.Write("\nТип (козетка, кресло, кресло-качалка, пуфик): ");
            armchair.TypeOfArmchair = Console.ReadLine();
            Console.Write("Вид (раскладные, нераскладные): ");
            armchair.Kind = Console.ReadLine();
            Console.Write("Высота: ");
            double.TryParse(Console.ReadLine(), out val);
            armchair.Height = val;
            Console.Write("Ширина: ");
            double.TryParse(Console.ReadLine(), out val);
            armchair.Width = val;
            Console.Write("Материал обивки: ");
            armchair.MaterialOfUpholstery = Console.ReadLine();
            Console.Write("Цвет: ");
            armchair.Color = Console.ReadLine();
            Console.Write("Производитель: ");
            armchair.Manufacturer = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            armchair.ProducingCountry = Console.ReadLine();
            Console.Write("Цена: ");
            double.TryParse(Console.ReadLine(), out val);
            armchair.Price = val;
            return armchair;
        }

        static Sofa CreateSofa()
        {
            Sofa sofa = new Sofa();
            double val;
            Console.Write("\nТип (офисный, детский, прямой, угловой): ");
            sofa.TypeOfSofa = Console.ReadLine();
            Console.Write("Вид (раскладные, нераскладные): ");
            sofa.Kind = Console.ReadLine();
            Console.Write("Mеханизм трансформации (выкатной, дельфин, еврокнижка, пума, седафлекс): ");
            sofa.MechanismTransformation = Console.ReadLine();
            Console.Write("Ширина: ");
            double.TryParse(Console.ReadLine(), out val);
            sofa.Width = val;
            Console.Write("Материал обивки: ");
            sofa.MaterialOfUpholstery = Console.ReadLine();
            Console.Write("Цвет: ");
            sofa.Color = Console.ReadLine();
            Console.Write("Производитель: ");
            sofa.Manufacturer = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            sofa.ProducingCountry = Console.ReadLine();
            Console.Write("Цена: ");
            double.TryParse(Console.ReadLine(), out val);
            sofa.Price = val;
            return sofa;
        }

        static Bed CreateBed()
        {
            Bed bed = new Bed();
            double val;
            Console.Write("\nТип (односпальные, двуспальные, полуторные): ");
            bed.TypeOfBed = Console.ReadLine();
            Console.Write("Длина: ");
            double.TryParse(Console.ReadLine(), out val);
            bed.Length = val;
            Console.Write("Ширина: ");
            double.TryParse(Console.ReadLine(), out val);
            bed.Width = val;
            Console.Write("Oснование под матрас (брус, дсп, ламели, металлические рейки): ");
            bed.BaseUnderMattress = Console.ReadLine();
            Console.Write("Материал обивки: ");
            bed.MaterialOfUpholstery = Console.ReadLine();
            Console.Write("Материал каркаса: ");
            bed.MaterialOfFrame = Console.ReadLine();
            Console.Write("Цвет: ");
            bed.Color = Console.ReadLine();
            Console.Write("Производитель: ");
            bed.Manufacturer = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            bed.ProducingCountry = Console.ReadLine();
            Console.Write("Цена: ");
            double.TryParse(Console.ReadLine(), out val);
            bed.Price = val;
            return bed;
        }

        static Cupboard CreateCupboard()
        {
            Cupboard cupboard = new Cupboard();
            double val;
            int count;
            Console.Write("\nТип (книжный, распашный, шкаф-купе, шкаф-пенал): ");
            cupboard.TypeOfCupboard = Console.ReadLine();
            Console.Write("Количество дверей: ");
            int.TryParse(Console.ReadLine(), out count);
            cupboard.CountDoors = count;
            Console.Write("Высота: ");
            double.TryParse(Console.ReadLine(), out val);
            cupboard.Height = val;
            Console.Write("Ширина: ");
            double.TryParse(Console.ReadLine(), out val);
            cupboard.Width = val;
            Console.Write("Материал фасада: ");
            cupboard.FacadeMaterial = Console.ReadLine();
            Console.Write("Материал корпуса: ");
            cupboard.MaterialOfBody = Console.ReadLine();
            Console.Write("Цвет: ");
            cupboard.Color = Console.ReadLine();
            Console.Write("Производитель: ");
            cupboard.Manufacturer = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            cupboard.ProducingCountry = Console.ReadLine();
            Console.Write("Цена: ");
            double.TryParse(Console.ReadLine(), out val);
            cupboard.Price = val;
            return cupboard;
        }
    }
}
