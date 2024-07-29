using System;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int arrayValue = 15;
            int minValue = 1;
            int maxValue = 50;
            int tempNumber = 0;

            int[] numbers = new int[arrayValue];

            Console.WriteLine($"Дан массив размером {arrayValue} чисел.");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        tempNumber = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = tempNumber;
                    }
                }
            }

            Console.WriteLine($"\n\nПредставлен упорядоченный вид массива: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
