using System;

class Program
{
    static void Main()
    {
        // Установка фона и цвета текста
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("Общая часть: Исследование функций модуля Math");
        Console.WriteLine("****************************************************");

        double x = 0, y = 0;

        // Ввод значения x с повторным запросом при ошибке
        while (true)
        {
            Console.Write("Введите значение x: ");
            if (double.TryParse(Console.ReadLine(), out x))
                break; // Если ввод корректен, выходим из цикла
            else
                Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
        }

        // Ввод значения y с повторным запросом при ошибке
        while (true)
        {
            Console.Write("Введите значение y: ");
            if (double.TryParse(Console.ReadLine(), out y))
                break; // Если ввод корректен, выходим из цикла
            else
                Console.WriteLine("Ошибка! Некорректные данные. Попробуйте еще раз.");
        }

        Console.WriteLine("****************************************************");
        Console.WriteLine("\n--- Результаты вычислений ---");

        // Функции Math с пояснениями
        Console.WriteLine($"Модуль числа: Math.Abs({x}) = {Math.Abs(x)}");
        Console.WriteLine($"Синус: Math.Sin({x}) = {Math.Sin(x)}");
        Console.WriteLine($"Косинус: Math.Cos({x}) = {Math.Cos(x)}");
        Console.WriteLine($"Тангенс: Math.Tan({x}) = {Math.Tan(x)}");
        Console.WriteLine($"Арккосинус: Math.Acos({x}) = {(x >= -1 && x <= 1 ? Math.Acos(x).ToString() : "Ошибка! Некорректные данные.")}");
        Console.WriteLine($"Арксинус: Math.Asin({x}) = {(x >= -1 && x <= 1 ? Math.Asin(x).ToString() : "Ошибка! Некорректные данные.")}");
        Console.WriteLine($"Арктангенс: Math.Atan({x}) = {Math.Atan(x)}");
        Console.WriteLine($"Функция Atan2: Math.Atan2({x}, {y}) = {Math.Atan2(x, y)}");
        Console.WriteLine($"Большое умножение: Math.BigMul({x}, {y}) = {Math.BigMul((int)x, (int)y)}");
        Console.WriteLine($"Округление вверх: Math.Ceiling({x}) = {Math.Ceiling(x)}");
        Console.WriteLine($"Округление вниз: Math.Floor({x}) = {Math.Floor(x)}");
        Console.WriteLine($"Квадратный корень: Math.Sqrt({x}) = {(x >= 0 ? Math.Sqrt(x).ToString() : "Ошибка! Некорректные данные.")}");
        Console.WriteLine($"Логарифм по основанию e: Math.Log({x}) = {(x > 0 ? Math.Log(x).ToString() : "Ошибка! Некорректные данные.")}");
        Console.WriteLine($"Логарифм по основанию 10: Math.Log10({x}) = {(x > 0 ? Math.Log10(x).ToString() : "Ошибка! Некорректные данные.")}");
        Console.WriteLine($"Экспонента: Math.Exp({x}) = {Math.Exp(x)}");
        Console.WriteLine($"Максимум (x, y): Math.Max({x}, {y}) = {Math.Max(x, y)}");
        Console.WriteLine($"Минимум (x, y): Math.Min({x}, {y}) = {Math.Min(x, y)}");
        Console.WriteLine($"Число PI: Math.PI = {Math.PI}");
        Console.WriteLine($"Число E: Math.E = {Math.E}");
        Console.WriteLine($"Возведение в степень: Math.Pow({x}, {y}) = {Math.Pow(x, y)}");
        Console.WriteLine($"Округление: Math.Round({x}) = {Math.Round(x)}");
        Console.WriteLine($"Знак числа: Math.Sign({x}) = {Math.Sign(x)}");
        Console.WriteLine($"Гиперболический синус: Math.Sinh({x}) = {Math.Sinh(x)}");
        Console.WriteLine($"Гиперболический косинус: Math.Cosh({x}) = {Math.Cosh(x)}");
        Console.WriteLine($"Гиперболический тангенс: Math.Tanh({x}) = {Math.Tanh(x)}");
        Console.WriteLine($"Отбрасывание дробной части: Math.Truncate({x}) = {Math.Truncate(x)}");

        Console.WriteLine("****************************************************");
        Console.WriteLine("\n--- Конец выполнения общей части ---");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
