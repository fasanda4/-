using System; // Подключение стандартного пространства имен для работы с основными функциями ввода-вывода

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя длину массива
        Console.Write("Введите длину массива: ");
        // Пытаемся преобразовать введенную строку в целое число
        // Если преобразование успешно, результат сохраняется в переменной n, а flg принимает значение true
        bool flg = Int32.TryParse(Console.ReadLine(), out int n);

        // Проверяем, удалось ли корректно преобразовать введенные данные
        if (flg == true)
        {
            // Создаем массив целых чисел длиной n
            int[] array = new int[n];

            // Цикл для ввода элементов массива пользователем
            for (int i = 0; i < array.Length; i++)
            {
                // Просим пользователя ввести i-й элемент массива
                Console.Write($"Введите {i + 1}-й элемент массива: ");
                // Пытаемся преобразовать введенную строку в целое число и записать в массив
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
                // Инициализируем индекс для поиска положительных чисел
                int positiveIndex = 0;

                // Находим первый отрицательный элемент в массиве
                while (positiveIndex < array.Length && array[positiveIndex] >= 0)
                {
                    positiveIndex++; // Перемещаемся к следующему элементу, пока он не станет отрицательным
                }

                // Устанавливаем индекс для поиска отрицательных элементов
                int negativeIndex = positiveIndex;

                // Находим следующий положительный элемент после отрицательного
                while (negativeIndex < array.Length && array[negativeIndex] < 0)
                {
                    negativeIndex++; // Пропускаем все отрицательные элементы
                }

                // Основной цикл перестановки положительных и отрицательных чисел
                while (positiveIndex < array.Length && negativeIndex < array.Length)
                {
                    // Обмен значениями между положительным и отрицательным элементами
                    int temp = array[positiveIndex];
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
