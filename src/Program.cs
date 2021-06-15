using System;

namespace Bubble_Sort
{
    class Program
    {using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = GetInput("Enter values separated by a comma");
            string[] numberArray = numbers.Split(',');
            int[] intNumberArray = new int[numberArray.Length];

            for (var i = 0; i < intNumberArray.Length; i++)
            {
                intNumberArray[i] = Convert.ToInt32(numberArray[i]);
            }

            bool moved = false;

            do
            {
                moved = false;
                for (var i = 0; i < intNumberArray.Length - 1; i++)
                {
                    if (intNumberArray[i] > intNumberArray[i + 1])
                    {
                        int x = intNumberArray[i];
                        intNumberArray[i] = intNumberArray[i + 1];
                        intNumberArray[i + 1] = x;
                        moved = true;
                    }
                }
            } while (moved == true);

            Console.Write("Sorted: ");
            int total = 0;
            for (var i = 0; i < intNumberArray.Length; i ++)
            {
                Console.Write(intNumberArray[i] + ", ");
                total += intNumberArray[i];
            }
            int median = total / intNumberArray.Length;
            Console.Write("\n");

            Console.WriteLine("Total entries: " + intNumberArray.Length);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Median: " + median);

            Console.WriteLine("Hello World!");
        }

        static string GetInput(string text)
        {
            Console.Write(text + ": ");
            return Console.ReadLine();
        }
    }
}

        static void Main(string[] args)
        {
            string numbers = GetInput("Enter values separated by a comma");
            string[] numberArray = numbers.Split(',');
            int[] intNumberArray = new int[numberArray.Length];

            for (var i = 0; i < intNumberArray.Length; i++)
            {
                intNumberArray[i] = Convert.ToInt32(numberArray[i]);
            }

            bool moved = false;

            do
            {
                moved = false;
                for (var i = 0; i < intNumberArray.Length - 1; i++)
                {
                    if (intNumberArray[i] > intNumberArray[i + 1])
                    {
                        int x = intNumberArray[i];
                        intNumberArray[i] = intNumberArray[i + 1];
                        intNumberArray[i + 1] = x;
                        moved = true;
                    }
                }
            } while (moved == true);

            Console.Write("Sorted: ");
            int total = 0;
            for (var i = 0; i < intNumberArray.Length; i ++)
            {
                Console.Write(intNumberArray[i] + ", ");
                total += intNumberArray[i];
            }
            int median = total / intNumberArray.Length;
            Console.Write("\n");

            Console.WriteLine("Total entries: " + intNumberArray.Length);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Median: " + median);

            Console.WriteLine("Hello World!");
        }

        static string GetInput(string text)
        {
            Console.Write(text + ": ");
            return Console.ReadLine();
        }
    }
}
