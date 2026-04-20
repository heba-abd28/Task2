using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            string[] fruits = { "Apple", "Banana", "Mango", "Orange", "Strawberry" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"Fruit at index {i}: {fruits[i]}");
            }

            Console.WriteLine($"Total number of fruits: {fruits.Length}");
            Console.WriteLine("----------------------------------------------");
            //Q2
            int[] numbers = new int[5];

            Console.WriteLine("Input 5 numbers into the array:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number at index {i}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Original Array
            Console.Write("Original array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            // عكس المصفوفة
            Array.Reverse(numbers);

            // طباعة المعكوس
            Console.Write("Reversed array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }


            //Q3
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            string[] colors = { "Red", "Blue", "Green", "rose", "Yellow", "Rosewood" };

            int count = 0;

            Console.Write("Colors starting with 'R': ");

            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i].StartsWith("R", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write(colors[i]);

                    count++;

                    if (i < colors.Length - 1)
                        Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total count: {count}");


            Console.WriteLine("----------------------------");
            //Q4
            int[] userNumbers = new int[6];

            Console.WriteLine("Input 6 numbers into the array:");

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.Write("Number at index " + i + ": ");
                userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

        
            int sum = userNumbers.Sum();
            double average = userNumbers.Average();
            int min = userNumbers.Min();
            int max = userNumbers.Max();

            Array.Sort(userNumbers);

            // الطباعة
            Console.WriteLine("\nSum of elements: " + sum);
            Console.WriteLine("Average of elements: " + average);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);

            Console.WriteLine("Sort: " + string.Join(", ", userNumbers));

        }
    }
}
