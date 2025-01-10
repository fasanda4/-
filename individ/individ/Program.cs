using System; // Подключение базовой библиотеки System для работы с консольным вводом и выводом

class Program // Объявление класса Program, содержащего точку входа в программу
{
    static void Main() // Метод Main — точка входа в программу
    {
        // Установка цветов консоли
        Console.BackgroundColor = ConsoleColor.White; // Установка белого фона
        Console.ForegroundColor = ConsoleColor.Black; // Установка черного цвета текста
        Console.Clear(); // Очистка консоли для применения новых цветов

        // Вывод заголовка программы
        Console.WriteLine("Индивидуальная задача: Нахождение максимального из пяти чисел");
        Console.WriteLine("****************************************************");

        // Инициализация переменной для хранения максимального значения
        double max = double.MinValue; // Начальное значение — минимальное возможное значение типа double

        // Метод для ввода одного числа с проверкой на корректность
        double input1, input2, input3, input4, input5; // Переменные для хранения введенных чисел

        Console.Write("Введите число 1: ");
        while (!double.TryParse(Console.ReadLine(), out input1))
        {
            Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
            Console.Write("Введите число 1: ");
        }
        if (input1 > max) max = input1; // Обновление значения max, если число больше текущего максимума

        Console.Write("Введите число 2: ");
        while (!double.TryParse(Console.ReadLine(), out input2))
        {
            Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
            Console.Write("Введите число 2: ");
        }
        if (input2 > max) max = input2; // Обновление значения max, если число больше текущего максимума

        Console.Write("Введите число 3: ");
        while (!double.TryParse(Console.ReadLine(), out input3))
        {
            Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
            Console.Write("Введите число 3: ");
        }
        if (input3 > max) max = input3; // Обновление значения max, если число больше текущего максимума

        Console.Write("Введите число 4: ");
        while (!double.TryParse(Console.ReadLine(), out input4))
        {
            Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
            Console.Write("Введите число 4: ");
        }
        if (input4 > max) max = input4; // Обновление значения max, если число больше текущего максимума

        Console.Write("Введите число 5: ");
        while (!double.TryParse(Console.ReadLine(), out input5))
        {
            Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
            Console.Write("Введите число 5: ");
        }
        if (input5 > max) max = input5; // Обновление значения max, если число больше текущего максимума

        // Вывод максимального значения из введенных чисел
        Console.WriteLine($"\nМаксимальное значение из введенных чисел: {max}");
        Console.WriteLine("****************************************************");

        // Завершение работы программы
        Console.WriteLine("Нажмите любую клавишу для выхода..."); // Сообщение пользователю о завершении
        Console.ReadKey(); // Ожидание нажатия любой клавиши для выхода
    }
}
