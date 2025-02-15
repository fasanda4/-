﻿using System; // Подключение базовой библиотеки для работы с основными функциями языка C#

class Program // Объявление главного класса программы
{
    static void Main(string[] args) // Основной метод программы, с которого начинается выполнение
    {
        // Объявление переменных, используемых в программе
        double k, b, d, a, a0, ak, da, e; // Числовые переменные для расчётов
        int count = 0; // Переменная для подсчёта итераций
        const double eps = 0.001; // Константа для минимального допустимого значения

        // Логические флаги для проверки условий
        bool flg1, flg2, flg3, flg4;

        // Вывод приглашения к вводу данных пользователем
        Console.WriteLine("--- Ввод данных ---");

        // Ввод значения k
        Console.Write("Введите значение k (должно быть больше 0): ");
        flg1 = double.TryParse(Console.ReadLine(), out k) && k > eps; // Проверка корректности ввода и значения
        if (!flg1)
        {
            Console.WriteLine("Ошибка! Некорректные данные."); // Сообщение об ошибке
            return; // Завершение программы
        }

        // Ввод значения b
        Console.Write("Введите значение b: ");
        flg2 = double.TryParse(Console.ReadLine(), out b); // Проверка корректности ввода
        if (!flg2)
        {
            Console.WriteLine("Ошибка! Некорректные данные."); // Сообщение об ошибке
            return; // Завершение программы
        }

        // Ввод значения d
        Console.Write("Введите значение d: ");
        flg3 = double.TryParse(Console.ReadLine(), out d); // Проверка корректности ввода
        if (!flg3)
        {
            Console.WriteLine("Ошибка! Некорректные данные."); // Сообщение об ошибке
            return; // Завершение программы
        }

        // Ввод начального значения диапазона a0
        Console.Write("Введите начало диапазона (a0): ");
        flg4 = double.TryParse(Console.ReadLine(), out a0); // Проверка корректности ввода
        if (!flg4)
        {
            Console.WriteLine("Ошибка! Некорректные данные."); // Сообщение об ошибке
            return; // Завершение программы
        }

        // Ввод конечного значения диапазона ak
        Console.Write("Введите конец диапазона (ak): ");
        flg4 = double.TryParse(Console.ReadLine(), out ak); // Повторное использование flg4 для проверки ввода
        if (!flg4)
        {
            Console.WriteLine("Ошибка! Некорректные данные."); // Сообщение об ошибке
            return; // Завершение программы
        }

        // Ввод шага da
        Console.Write("Введите шаг (da): ");
        flg4 = double.TryParse(Console.ReadLine(), out da) && da > 0; // Проверка корректности ввода и значения
        if (!flg4)
        {
            Console.WriteLine("Ошибка! Некорректные данные."); // Сообщение об ошибке
            return; // Завершение программы
        }

        // Установка начального значения переменной a для итераций
        a = a0; // Присваиваем начальное значение диапазона

        // Основной цикл программы с предусловием
        while (a <= ak) // Условие выполнения цикла: пока a меньше или равно конечному значению диапазона
        {
            count++; // Увеличиваем счётчик итераций

            // Проверяем условия существования результата e
            flg1 = Math.Pow(a, 2) + b * Math.Cos(b) >= eps; // Условие 1: выражение должно быть больше или равно eps
            flg2 = Math.Abs(Math.Sqrt(Math.Pow(a, 2) + b * Math.Cos(b))) >= eps; // Условие 2: значение под корнем должно быть допустимым
            flg3 = Math.Abs(Math.Cos(a * a)) >= eps; // Условие 3: косинус значения не должен быть слишком мал
            flg4 = Math.Abs(k) >= eps && Math.Abs(a) >= eps; // Условие 4: значения k и a должны быть больше минимального значения

            if (flg1 && flg2 && flg3 && flg4) // Если все условия выполнены
            {
                // Вычисляем значение e по заданной формуле
                e = (0.1 * k) + ((Math.Pow(Math.PI, (1 / k) + d) * Math.Tan(a * a) * Math.Pow(k, 1 / a))
                    / Math.Sqrt(Math.Pow(a, 2) + b * Math.Cos(b)));
                Console.WriteLine($"{count}) При a = {a:F3}, e = {e:F3}"); // Вывод результата расчёта
            }
            else // Если хотя бы одно условие не выполнено
            {
                Console.WriteLine($"{count}) При a = {a:F3}, e не существует"); // Сообщение о невозможности расчёта
            }

            // Увеличиваем значение a на шаг da
            a += da;
        }

        // Сообщение об окончании расчётов
        Console.WriteLine("\nРасчёты завершены.");
        Console.ReadKey(); // Ожидание нажатия клавиши для завершения программы
    }
}
