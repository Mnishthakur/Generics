namespace Generics;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test case 1: Max number is at first position");
            int max1 = FindMax(10, 2, 1);
            Console.WriteLine("Max number is: " + max1); // Output: Max number is: 10

            Console.WriteLine("Test case 2: Max number is at second position");
            int max2 = FindMax(5, 53, 2);
            Console.WriteLine("Max number is: " + max2); // Output: Max number is: 53

            Console.WriteLine("Test case 3: Max number is at third position");
            int max3 = FindMax(10, 3, 14);
            Console.WriteLine("Max number is: " + max3); // Output: Max number is: 14
        }

        static int FindMax(int a, int b, int c)
        {
            int max = int.MinValue;
            if (a.CompareTo(max) > 0)
            {
                max = a;
            }
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
    }
