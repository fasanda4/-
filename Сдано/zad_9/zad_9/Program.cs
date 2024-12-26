using System; // Подключение стандартного пространства имен для работы с основными функциями ввода-вывода

class Program
{
    static void Main(string[] args)
    {
        // Блок объявления всех переменных
        int n = 0; // Длина массива
        int[] array = null; // Массив целых чисел
        bool flg = false; // Флаг для проверки корректности ввода
        int positiveIndex = 0; // Индекс для положительных элементов
        int negativeIndex = 0; // Индекс для отрицательных элементов
        int temp = 0; // Переменная для обмена значений

        // Запрашиваем у пользователя длину массива
        Console.Write("Введите длину массива: ");

        // Пытаемся преобразовать введенную строку в целое число
        flg = Int32.TryParse(Console.ReadLine(), out n);

        // Проверяем, удалось ли корректно преобразовать введенные данные
        if (flg == true)
        {
            // Создаем массив целых чисел длиной n
            array = new int[n];

            // Цикл для ввода элементов массива пользователем
            for (int i = 0; i < array.Length; i++)
            {
                // Просим пользователя ввести i-й элемент массива
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                flg = Int32.TryParse(Console.ReadLine(), out array[i]);

                // Если введенные данные некорректны, выходим из цикла
                if (flg == false)
                {
                    break; // Прерываем выполнение ввода, если обнаружена ошибка
                }
            }

            // Проверяем, успешно ли были введены все элементы массива
            if (flg == true)
            {
                // Находим первый отрицательный элемент в массиве
                positiveIndex = 0;
                while (positiveIndex < array.Length && array[positiveIndex] >= 0)
                {
                    positiveIndex++; // Перемещаемся к следующему элементу, пока он не станет отрицательным
                }

                // Устанавливаем индекс для поиска отрицательных элементов
                negativeIndex = positiveIndex;

                // Находим следующий положительный элемент после отрицательного
                while (negativeIndex < array.Length && array[negativeIndex] < 0)
                {
                    negativeIndex++; // Пропускаем все отрицательные элементы
                }

                // Основной цикл перестановки положительных и отрицательных чисел
                while (positiveIndex < array.Length && negativeIndex < array.Length)
                {
                    // Обмен значениями между положительным и отрицательным элементами
                    temp = array[positiveIndex];
                    array[positiveIndex] = array[negativeIndex];
                    array[negativeIndex] = temp;

                    // Сдвигаем оба индекса к следующим элементам
                    positiveIndex++;
                    negativeIndex++;

                    // Находим следующий положительный элемент
                    while (positiveIndex < array.Length && array[positiveIndex] >= 0)
                    {
                        positiveIndex++;
                    }

                    // Находим следующий отрицательный элемент
                    while (negativeIndex < array.Length && array[negativeIndex] < 0)
                    {
                        negativeIndex++;
                    }
                }

                // Выводим результирующий массив
                Console.WriteLine("Результирующий массив:");
                for (int i = 0; i < array.Length; i++)
                {
                    // Выводим каждый элемент массива через пробел
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                // Сообщение об ошибке, если хотя бы один из элементов массива введен некорректно
                Console.WriteLine("Введены неверные данные");
            }
        }
        else
        {
            // Сообщение об ошибке, если длина массива введена некорректно
            Console.WriteLine("Введены неверные данные");
        }

        // Завершаем выполнение программы, ожидая нажатия клавиши, чтобы пользователь успел увидеть результат
        Console.ReadKey(true);
    }
}
