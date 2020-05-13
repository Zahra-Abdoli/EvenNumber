using System;

namespace Even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"enter your number {i + 1}:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int number in numbers)
            {
                if (number % 2 == 0) Console.WriteLine(number);
            }
;
        }
    }
}
