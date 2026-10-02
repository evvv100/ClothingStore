using ClothingStore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ClothingCategory1;
using ClothingSize1;
using Logic1;

namespace ClothingStore.ConsoleApp
{
    internal class Program
    {
        private static Logic store = new Logic();
        private static Random rnd = new Random();
        private static int balance = rnd.Next(10000, 20001);
        private static List<Clothing> historyList = new List<Clothing>();

        static void Main(string[] args)
        {
            store.AddClothing(new Clothing(1, "Белая футболка", ClothingCategory.TShirt, ClothingSize.M, 1500));
            store.AddClothing(new Clothing(2, "Черная футболка", ClothingCategory.TShirt, ClothingSize.L, 1800));
            store.AddClothing(new Clothing(3, "Синие джинсы", ClothingCategory.Jeans, ClothingSize.XL, 4500));
            store.AddClothing(new Clothing(4, "Черные джинсы", ClothingCategory.Jeans, ClothingSize.S, 4200));
            store.AddClothing(new Clothing(5, "Джинсовая куртка", ClothingCategory.Jacket, ClothingSize.M, 6500));
            store.AddClothing(new Clothing(6, "Зимний пуховик", ClothingCategory.Jacket, ClothingSize.XL, 12000)); 
            store.AddClothing(new Clothing(7, "Зеленые шорты", ClothingCategory.Shorts, ClothingSize.M, 350));
            store.AddClothing(new Clothing(8, "Джинсовые шорты", ClothingCategory.Shorts, ClothingSize.S, 400));
            store.AddClothing(new Clothing(9, "Черное платье", ClothingCategory.Dress, ClothingSize.M, 5500));
            store.AddClothing(new Clothing(10, "Летнее платье", ClothingCategory.Dress, ClothingSize.XS, 3800));

            while(true)
            {
                Console.WriteLine("\tДобро пожаловать в магазин одежды!\n\n" +
                    "Введите номер действия:\n\t" +
                    "[1] Посмотреть ассортимент\n\t" +
                    "[2] Добавить одежду\n\t" +
                    "[3] Удалить одежду\n\t" +
                    "[4] Найти одежду по ID\n\t" +
                    "[5] Изменить одежду\n\t" +
                    "[6] Собрать корзину\n\t" +
                    "[7] Отфильтровать по размеру\n\t"+
                    "[8] История покупок и возврат товара\n\t" +
                    "[0] Выход\n");

                Console.Write("\nВаш выбор: ");
                string choice = Console.ReadLine();

                if (int.TryParse(choice, out int rchoice))
                {
                    if(rchoice > 8 || rchoice < 1)
                    {
                        Console.WriteLine("Ввод неверный! Попробуйте снова.");
                    }
                    else
                    {
                        switch (choice)
                        {
                            case "1":
                                store.ReturnList(out List<Clothing> allClothes);
                                Console.WriteLine($"\n--- АССОРТИМЕНТ МАГАЗИНА --- | ВАШ БАЛАНС: {balance} руб.");
                                PrintClothesList(allClothes);
                                break;

                            case "2":
                                Console.WriteLine("\n--- ДОБАВЛЕНИЕ ОДЕЖДЫ ---");
                                string stId = "";
                                int newId = 0;
                                while(true)
                                {
                                    Console.Write("Введите ID: ");
                                    stId = Console.ReadLine();
                                    if(int.TryParse(stId, out newId))
                                    {
                                        if (store.GetClothingById(newId) != null)
                                        {
                                            Console.WriteLine("Этот ID уже существует.");
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }

                                }
                                Console.Write("Введите название: ");
                                string name = Console.ReadLine();

                                string inputText1 = "";
                                ClothingCategory cat = ClothingCategory.TShirt;
                                bool ok1 = false;
                                while (ok1 == false)
                                {
                                    Console.Write("Введите категорию:\n\t" +
                                        "1) TShirt\n\t" +
                                        "2) Jeans\n\t" +
                                        "3) Jacket\n\t" +
                                        "4) Socks\n\t" +
                                        "5) Dress\n\t");
                                    inputText1 = Console.ReadLine();
                                    switch (inputText1)
                                    {
                                        case "1":
                                            cat = ClothingCategory.TShirt;
                                            ok1 = true;
                                            break;
                                        case "2":
                                            cat = ClothingCategory.Jeans;
                                            ok1 = true;
                                            break;
                                        case "3":
                                            cat = ClothingCategory.Jacket;
                                            ok1 = true;
                                            break;
                                        case "4":
                                            cat = ClothingCategory.Shorts;
                                            ok1 = true;
                                            break;
                                        case "5":
                                            cat = ClothingCategory.Dress;
                                            ok1 = true;
                                            break;
                                        default:
                                            Console.WriteLine("Неверный пункт меню. Попробуйте еще раз.");
                                            break;
                                    }
                                }

                                string inputText = "";
                                ClothingSize size = ClothingSize.XL;
                                bool ok = false;
                                while(ok == false)
                                {
                                    Console.Write("Введите размер:\n\t" +
                                        "1) XS\n\t" +
                                        "2) S\n\t" +
                                        "3) M\n\t" +
                                        "4) L\n\t" +
                                        "5) XL\n\t");
                                    inputText = Console.ReadLine();
                                    switch (inputText)
                                    {
                                        case "1":
                                            size = ClothingSize.XS;
                                            ok = true;
                                            break;
                                        case "2":
                                            size = ClothingSize.S;
                                            ok = true;
                                            break;
                                        case "3":
                                            size = ClothingSize.M;
                                            ok = true;
                                            break;
                                        case "4":
                                            size = ClothingSize.L;
                                            ok = true;
                                            break;
                                        case "5":
                                            size = ClothingSize.XL;
                                            ok = true;
                                            break;
                                        default:
                                            Console.WriteLine("Неверный пункт меню. Попробуйте еще раз.");
                                            break;
                                    }  
                                }

                                string price2 = "";
                                int price = 0;
                                while(true)
                                {
                                    Console.Write("Введите цену: ");
                                    price2 = Console.ReadLine();
                                    if(int.TryParse(price2, out price))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }
                                }

                                Clothing newClothing = new Clothing(newId, name, cat, size, price);
                                store.AddClothing(newClothing);
                                Console.WriteLine("Товар успешно добавлен!");
                                break;

                            case "3":
                                Console.WriteLine("\n--- УДАЛЕНИЕ ОДЕЖДЫ ---");
                                int removeId = 0;
                                string removeId1 = "";
                                while (true)
                                {
                                    Console.Write("Введите ID товара для удаления: ");
                                    removeId1 = Console.ReadLine();
                                    if (int.TryParse(removeId1, out removeId))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }
                                }
                                store.RemoveClothing(removeId);
                                Console.WriteLine("Запрос на удаление выполнен.");
                                break;

                            case "4":
                                Console.WriteLine("\n--- ПОИСК ПО ID ---");
                                int searchId = 0;
                                string searchId1 = "";
                                while (true)
                                {
                                    Console.Write("Введите ID товара: ");
                                    searchId1 = Console.ReadLine();
                                    if (int.TryParse(searchId1, out searchId))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }
                                }
                                Clothing found = store.GetClothingById(searchId);
                                if (found != null)
                                {
                                    Console.WriteLine($"\nКарточка товара:\nID: {found.ID}\nНазвание: {found.Name}\nКатегория: {found.Category}\nРазмер: {found.Size}\nЦена: {found.Price} руб.");
                                }
                                else
                                {
                                    Console.WriteLine("Товар с таким ID не найден.");
                                }
                                break;

                            case "5":
                                Console.WriteLine("\n--- ИЗМЕНЕНИЕ ДАННЫХ ОДЕЖДЫ ---");
                                int changeIdC = 0;
                                string changeId1C = "";
                                while (true)
                                {
                                    Console.Write("Введите ID товара, который хотите изменить: ");
                                    changeId1C = Console.ReadLine();
                                    if (int.TryParse(changeId1C, out changeIdC))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }
                                }

                                if (store.GetClothingById(changeIdC) == null)
                                {
                                    Console.WriteLine("Товара с таким ID нет!");
                                    break;
                                }

                                Console.Write("Введите новое название: ");
                                string newName = Console.ReadLine();
                                string inputText1C = "";
                                ClothingCategory catC = ClothingCategory.TShirt;
                                bool ok1C = false;
                                while (ok1C == false)
                                {
                                    Console.Write("Введите категорию:\n\t" +
                                        "1) TShirt\n\t" +
                                        "2) Jeans\n\t" +
                                        "3) Jacket\n\t" +
                                        "4) Socks\n\t" +
                                        "5) Dress\n\t");
                                    inputText1C = Console.ReadLine();
                                    switch (inputText1C)
                                    {
                                        case "1":
                                            catC = ClothingCategory.TShirt;
                                            ok1C = true;
                                            break;
                                        case "2":
                                            catC = ClothingCategory.Jeans;
                                            ok1C = true;
                                            break;
                                        case "3":
                                            catC = ClothingCategory.Jacket;
                                            ok1C = true;
                                            break;
                                        case "4":
                                            catC= ClothingCategory.Shorts;
                                            ok1C = true;
                                            break;
                                        case "5":
                                            catC = ClothingCategory.Dress;
                                            ok1C = true;
                                            break;
                                        default:
                                            Console.WriteLine("Неверный пункт меню. Попробуйте еще раз.");
                                            break;
                                    }
                                }

                                string inputTextC = "";
                                ClothingSize sizeC = ClothingSize.XL;
                                bool okC = false;
                                while (okC == false)
                                {
                                    Console.Write("Введите размер:\n\t" +
                                        "1) XS\n\t" +
                                        "2) S\n\t" +
                                        "3) M\n\t" +
                                        "4) L\n\t" +
                                        "5) XL\n\t");
                                    inputTextC = Console.ReadLine();
                                    switch (inputTextC)
                                    {
                                        case "1":
                                            sizeC = ClothingSize.XS;
                                            okC = true;
                                            break;
                                        case "2":
                                            sizeC = ClothingSize.S;
                                            okC = true;
                                            break;
                                        case "3":
                                            sizeC = ClothingSize.M;
                                            okC = true;
                                            break;
                                        case "4":
                                            sizeC = ClothingSize.L;
                                            okC = true;
                                            break;
                                        case "5":
                                            sizeC = ClothingSize.XL;
                                            okC = true;
                                            break;
                                        default:
                                            Console.WriteLine("Неверный пункт меню. Попробуйте еще раз.");
                                            break;
                                    }
                                }

                                string price2C = "";
                                int priceC = 0;
                                while (true)
                                {
                                    Console.Write("Введите цену: ");
                                    price2C = Console.ReadLine();
                                    if (int.TryParse(price2C, out priceC))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }
                                }

                                Clothing updatedClothing = new Clothing(changeIdC, newName, catC, sizeC, priceC);
                                store.ChangeClothing(updatedClothing);
                                Console.WriteLine("Данные товара успешно обновлены!");
                                break;

                            case "6":
                                Console.WriteLine("\n--- СБОР КОРЗИНЫ ---");
                                store.ReturnList(out List<Clothing> availableClothes);
                                Console.WriteLine("Доступные товары на складе:");
                                PrintClothesList(availableClothes);
                                string inputIds = "";
                                List<int> basketIds = new List<int>();

                                while (true)
                                {
                                    basketIds.Clear();
                                    Console.WriteLine($"\n[Текущий баланс вашего кошелька: {balance} руб.]");
                                    Console.Write("\nВведите ID товаров через пробел, которые хотите купить: ");
                                    inputIds = Console.ReadLine();

                                    foreach (var s in inputIds.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                                    {
                                        if (int.TryParse(s, out int parsedId))
                                        {
                                            if (!basketIds.Contains(parsedId))
                                            {
                                                basketIds.Add(parsedId);
                                            }
                                            else
                                                basketIds.Add(-1); 
                                        }    
                                        else
                                        {
                                            basketIds.Add(-1);
                                        }
                                    }
                                    if(basketIds.Contains(-1))
                                    {
                                        Console.WriteLine("Неверный ввод, попробуйте снова.");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                for (int i = 0; i < basketIds.Count; i++)
                                {
                                    Clothing cl = store.GetClothingById(basketIds[i]);
                                    historyList.Add(cl);
                                }
                                int totalCost = store.AssembleBasket(ref basketIds);
                                Console.WriteLine($"\nТовары добавлены в корзину! Итоговая стоимость покупки: {totalCost} руб.");
                                Console.WriteLine("\n\t- Совершить покупку?\n\t[1] - Да\n\tЛюбая другая клавиша - возврат в меню");
                                if(Console.ReadLine() == "1")
                                {
                                    if (totalCost > balance)
                                    {
                                        Console.WriteLine("У вас недостаточно средств! Попробуйте совершить покупку позже.");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        balance-= totalCost;
                                        Console.WriteLine($"Поздравляем с покупкой! Ваш баланс: {balance}");
                                    }
                                }
                                
                                break;

                            case "7":
                                Console.WriteLine("\n--- ФИЛЬТРАЦИЯ ПО РАЗМЕРУ ---");
                                string inputTextF = "";
                                ClothingSize sizeF = ClothingSize.XL;
                                bool okF = false;
                                while (okF == false)
                                {
                                    Console.Write("Введите размер:\n\t" +
                                        "1) XS\n\t" +
                                        "2) S\n\t" +
                                        "3) M\n\t" +
                                        "4) L\n\t" +
                                        "5) XL\n\t");
                                    inputTextF = Console.ReadLine();
                                    switch (inputTextF)
                                    {
                                        case "1":
                                            sizeF = ClothingSize.XS;
                                            okF = true;
                                            break;
                                        case "2":
                                            sizeF = ClothingSize.S;
                                            okF = true;
                                            break;
                                        case "3":
                                            sizeF = ClothingSize.M;
                                            okF = true;
                                            break;
                                        case "4":
                                            sizeF = ClothingSize.L;
                                            okF = true;
                                            break;
                                        case "5":
                                            sizeF = ClothingSize.XL;
                                            okF = true;
                                            break;
                                        default:
                                            Console.WriteLine("Неверный пункт меню. Попробуйте еще раз.");
                                            break;
                                    }
                                }

                                store.FilterSize(out List<Clothing> filteredClothes, sizeF);

                                Console.WriteLine($"\nРезультаты фильтрации для размера {sizeF}:");
                                PrintClothesList(filteredClothes);
                                break;

                            case "8":
                                Console.WriteLine($"\n--- ИСТОРИЯ КУПЛЕННЫХ ТОВАРОВ --- | ВАШ БАЛАНС: {balance} руб.");
                                if (historyList.Count == 0)
                                {
                                    Console.WriteLine("Вы еще ничего не купили.");
                                    break;
                                }
                                PrintClothesList(historyList); 
                                Console.Write("\nХотите оформить возврат товара? (1 - Да, любой другой символ - Назад): ");
                                if (Console.ReadLine() == "1")
                                {
                                    Console.WriteLine($"\n[Ваш баланс до возврата: {balance} руб.]");
                                    Console.Write("Введите артикул (ID) товара для возврата: ");
                                    if (int.TryParse(Console.ReadLine(), out int returnId))
                                    {
                                        Clothing itemToReturn = historyList.Find(x => x.ID == returnId);
                                        if (itemToReturn != null)
                                        {
                                            balance += itemToReturn.Price;
                                            historyList.Remove(itemToReturn);
                                            store.AddClothing(itemToReturn); 
                                            Console.WriteLine($"Товар '{itemToReturn.Name}' успешно возвращен! {itemToReturn.Price} руб. возвращены на баланс.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Товар с таким ID не найден в истории ваших покупок.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный формат ID.");
                                    }
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод! Попробуйте снова.");
                }
                Console.WriteLine("\nНажмите любую клавишу для возврата в меню.");
                Console.ReadKey();
                Console.Clear(); 
            }
        }
        /// <summary>
        /// Выводит в консоль список одежды
        /// </summary>
        /// <param name="list">Список одежды, которую нужно вывести в консоль</param>
        private static void PrintClothesList(List<Clothing> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Список пуст.");
                return;
            }

            foreach (var item in list)
            {
                Console.WriteLine($"ID: {item.ID} | {item.Name} | Категория: {item.Category} | Размер: {item.Size} | Цена: {item.Price} руб.");
            }
        }
    }
}


