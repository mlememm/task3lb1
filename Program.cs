using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Визначення кількості додатних чисел у масиві.");
        Console.WriteLine("---------------------------------------------");

        int arraySize;
        bool isValidSize = false;
        do
        {
            Console.Write("Введіть бажаний розмір масиву (ціле додатне число): ");
            isValidSize = int.TryParse(Console.ReadLine(), out arraySize);

            if (!isValidSize || arraySize <= 0)
            {
                Console.WriteLine("Некоректний ввід. Введіть додатне ціле число для розміру масиву.");
                isValidSize = false;
            }
        } while (!isValidSize);
        int[] numbers = new int[arraySize];
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < arraySize; i++)
        {
            int number;
            bool isValidNumber = false;
            do
            {
                Console.Write($"Введіть елемент {i + 1} з {arraySize}: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out number);

                if (!isValidNumber)
                {
                    Console.WriteLine("Некоректний ввід. Введіть ціле число.");
                }
            } while (!isValidNumber);
            numbers[i] = number;
        }
        int positiveCount = 0;
        Console.Write("Ваш масив чисел: [");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positiveCount++;
            }
        }
        Console.WriteLine($"Кількість додатних чисел у масиві: {positiveCount}");
        Console.WriteLine("---------------------------------------------");
    }
}