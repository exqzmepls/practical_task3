using System;

namespace practical_task3
{
    public class Program
    {
        // Ввод действительного числа с клавиатуры
        public static double DoubleInput(string info = "")
        {
            bool exit;
            double result;
            Console.Write(info);
            do
            {
                exit = double.TryParse(Console.ReadLine(), out result);
                if (!exit) Console.Write("Введено не число! Повторите ввод: ");
            } while (!exit);
            return result;
        }

        // Вывод меню
        static void PrintMenu(string[] menuItems, int choice, string info)
        {
            Console.Clear();
            Console.WriteLine(info);
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == choice) Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{i + 1}. {menuItems[i]}");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        // Выбор пункта из меню
        static int MenuChoice(string[] menuItems, string info = "")
        {
            Console.CursorVisible = false;
            int choice = 0;
            while (true)
            {
                PrintMenu(menuItems, choice, info);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice == 0) choice = menuItems.Length;
                        choice--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice == menuItems.Length - 1) choice = -1;
                        choice++;
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        return choice;
                }
            }
        }

        // Проверка на принадлежность области
        public static bool Belongs(double x, double y)
        {
            return y >= -1 && y <= -3 * x + 2 && y <= 3 * x + 2;
        }

        static void Main(string[] args)
        {
            // Пункты меню
            string[] MENU_ITEMS = { "Проверить точку", "Выйти из программы" };

            // Индекс пункта - выход из программы
            const int EXIT_CHOICE = 1;
            
            // Индекс пункта меню, который выбрал пользователь
            int userChoice;
            
            // Координаты точки
            double x, y;
            
            do
            {
                // Пользователь выбирает дейтвие (выйти или проверить точку)
                userChoice = MenuChoice(MENU_ITEMS, "Выберите действие:");
                if (userChoice == EXIT_CHOICE) break;
                Console.Clear();

                // Ввод координат
                x = DoubleInput("Введите значение координаты Х: ");
                y = DoubleInput("Введите значение координаты Y: ");
                Console.Clear();

                // Вывод результата
                Console.WriteLine($"Точка ({x};{y}) {(Belongs(x, y) ? "принадлежит" : "не принадлежит")} данной области.");
                Console.WriteLine("Нажминет Enter, чтобы вернуться в меню...");
                Console.ReadLine();

            } while (true);
        }
    }
}
