using System;
using System.Globalization;

namespace Even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"enter your number {i + 1}:  (repetetive number does not count)");
                try
                {

                    int search = Convert.ToInt32(Console.ReadLine());
                    bool IsSame = false;

                    for (int j = 0; j < i; j++)
                    {
                        int item = numbers[j];
                        if (item == search) { IsSame = true; i--; break; }

                    }
                    if (!IsSame) numbers[i] = search;
                }
                catch
                {
                    Console.WriteLine("plese enter number");
                    i--;
                }
            }
            bool a = false;
            foreach (int number in numbers)
            {
                if (number != 0 && number % 2 == 0)
                {

                    Console.WriteLine(number);
                    a = true;
                }
                if (number == 0) Console.WriteLine(number);
            }
            if (!a) Console.WriteLine("non of them");
            ;
        }
    }
}
