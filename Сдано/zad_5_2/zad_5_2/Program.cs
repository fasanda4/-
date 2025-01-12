using System;

class Program
{
    static void Main()
    {
        // Блок ввода данных
        Console.WriteLine("Введите координаты точки A (x1, y1):");
        if (!double.TryParse(Console.ReadLine(), out double x1) || !double.TryParse(Console.ReadLine(), out double y1))
        {
            Console.WriteLine("Ошибка: некорректный ввод координат точки A.");
            return;
        }

        Console.WriteLine("Введите координаты точки B (x2, y2):");
        if (!double.TryParse(Console.ReadLine(), out double x2) || !double.TryParse(Console.ReadLine(), out double y2))
        {
            Console.WriteLine("Ошибка: некорректный ввод координат точки B.");
            return;
        }

        Console.WriteLine("Введите координаты точки C (x3, y3):");
        if (!double.TryParse(Console.ReadLine(), out double x3) || !double.TryParse(Console.ReadLine(), out double y3))
        {
            Console.WriteLine("Ошибка: некорректный ввод координат точки C.");
            return;
        }

        // Блок расчетов
        double area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;

        // Блок вывода результата
        if (area == 0)
        {
            Console.WriteLine("Точки лежат на одной прямой.");
        }
        else
        {
            Console.WriteLine("Точки не лежат на одной прямой.");
        }
    }
}
