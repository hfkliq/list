using System;

class Program
{
    static void Main()
    {
        List<string> fio = new List<string>(); 

        Console.WriteLine("Введите свою фамилию:");
        fio.Add(Console.ReadLine());

        Console.WriteLine("Введите своё имя:");
        fio.Add(Console.ReadLine());

        Console.WriteLine("Введите своё отчество:");
        fio.Add(Console.ReadLine());

        while (true) 
        {
            // Выбор операции
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1 - Вытащить фамилию, имя или отчество отдельно");
            Console.WriteLine("2 - Отсортировать фамилию по возрастанию или убыванию");
            Console.WriteLine("3 - Изменить фамилию, имя или отчество");
            Console.WriteLine("4 - Проверить длину каждой части ФИО");
            Console.WriteLine("5 - Сменить порядок ФИО");
            Console.WriteLine("0 - Выход");

            string choice = Console.ReadLine();

            if (choice == "0")
                break;

            switch (choice)
            {
                case "1":
                    ExtractPart(fio); // Вывод отдельной части ФИО
                    break;
                case "2":
                    Sortfamiliaimyaotchestvo(fio); // Сортировка фамилии
                    break;
                case "3":
                    ChangePart(fio); // Изменение части ФИО
                    break;
                case "4":
                    CheckLength(fio); // Проверка длины слов в ФИО
                    break;
                case "5":
                    ChangeOrder(fio); // Смена порядка слов в ФИО
                    break;
                default:
                    Console.WriteLine("Неправильно.");
                    break;
            }
        }
    }

    // Извлечение части ФИО по выбору пользователя
    static void ExtractPart(List<string> fio)
    {
        Console.WriteLine("Выберите часть ФИО:");
        Console.WriteLine("1 - Фамилия");
        Console.WriteLine("2 - Имя");
        Console.WriteLine("3 - Отчество");

        string choice = Console.ReadLine();
        if (choice == "1")
            Console.WriteLine("Фамилия: " + fio[0]);
        else if (choice == "2")
            Console.WriteLine("Имя: " + fio[1]);
        else if (choice == "3")
            Console.WriteLine("Отчество: " + fio[2]);
        else
            Console.WriteLine("Некорректный ввод.");
    }

    // Сортировка слов в ФИО по возрастанию или убыванию
    static void Sortfamiliaimyaotchestvo(List<string> fio)
    {
        Console.WriteLine("Выберите порядок сортировки слов в ФИО:");
        Console.WriteLine("1 - По возрастанию");
        Console.WriteLine("2 - По убыванию");

        string choice = Console.ReadLine();

        if (choice == "1")
            fio.Sort(); 
        else if (choice == "2")
            fio.Sort((a, b) => b.CompareTo(a));
        else
        {
            Console.WriteLine("Некорректный ввод.");
            return;
        }

        Console.WriteLine("Отсортированное ФИО: " + string.Join(" ", fio));
    }

    // Изменение выбранной части ФИО
    static void ChangePart(List<string> fio)
    {
        Console.WriteLine("Выберите часть ФИО для изменения:");
        Console.WriteLine("1 - Фамилия");
        Console.WriteLine("2 - Имя");
        Console.WriteLine("3 - Отчество");

        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("Введите новую фамилию:");
            fio[0] = Console.ReadLine();
        }
        else if (choice == "2")
        {
            Console.WriteLine("Введите новое имя:");
            fio[1] = Console.ReadLine();
        }
        else if (choice == "3")
        {
            Console.WriteLine("Введите новое отчество:");
            fio[2] = Console.ReadLine();
        }
        else
            Console.WriteLine("Некорректный ввод.");
    }

    // Проверка длины каждого слова в ФИО
    static void CheckLength(List<string> fio)
    {
        Console.WriteLine("Длина фамилии: " + fio[0].Length);
        Console.WriteLine("Длина имени: " + fio[1].Length);
        Console.WriteLine("Длина отчества: " + fio[2].Length);
    }

    // Смена порядка слов в ФИО
    static void ChangeOrder(List<string> fio)
    {
        Console.WriteLine("Выберите порядок отображения ФИО:");
        Console.WriteLine("1 - Фамилия Имя Отчество");
        Console.WriteLine("2 - Имя Отчество Фамилия");

        string choice = Console.ReadLine();
        if (choice == "1")
            Console.WriteLine("ФИО: " + fio[0] + " " + fio[1] + " " + fio[2]);
        else if (choice == "2")
            Console.WriteLine("ФИО: " + fio[1] + " " + fio[2] + " " + fio[0]);
        else
            Console.WriteLine("Некорректный ввод.");
    }
}
