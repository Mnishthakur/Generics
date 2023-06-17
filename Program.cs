namespace Generics;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test case 1: Max number is at first position");
            float max1 = FindMax(10.5f, 2.3f, 1.1f);
            Console.WriteLine("Max number is: " + max1); // Output: Max number is: 10.5

            Console.WriteLine("Test case 2: Max number is at second position");
            float max2 = FindMax(5.7f, 53.2f, 2.8f);
            Console.WriteLine("Max number is: " + max2); // Output: Max number is: 53.2

            Console.WriteLine("Test case 3: Max number is at third position");
            float max3 = FindMax(10.1f, 3.2f, 14.8f);
            Console.WriteLine("Max number is: " + max3); // Output: Max number is: 14.8
        }

        static float FindMax(float a, float b, float c)
        {
            float max = float.MinValue;
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
}
