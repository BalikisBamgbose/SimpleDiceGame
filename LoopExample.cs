using System;
//namespace Loop;


public class LoopExample
{   
        public static void PrintWholeNumbers()
        {
            Console.WriteLine("The first 10 whole numbers are: ");
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i++);
            }
        }

        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i < number; i++)
            {
                int result = i * number;

                Console.WriteLine($"{i} * {number} = {result}");
            }
        }

        public static void PrintNumber(int number)
        {
            Console.WriteLine($"The numbers from 1 to {number} not divisible by 3 and 7 are: ");

            for (int j = 1; j <= number; j++)
            {
                if (j % 3 != 0 && j % 7 != 0)
                {
                    Console.Write(j + " ");
                }
            }

            int i = 1;

            while (i <= number)
            {
                ++i;
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            do
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            while (i <= number);
        }
}

