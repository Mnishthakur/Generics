namespace Generics;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test case 1: Max number is at first position");
            int maxInt1 = FindMax<int>(9, 2, 1);
            Console.WriteLine("Max number is: " + maxInt1); 

            Console.WriteLine("Test case 2: Max number is at second position");
            float maxFloat2 = FindMax<float>(25.5f, 53.2f, 68.9f);
            Console.WriteLine("Max number is: " + maxFloat2); 

            Console.WriteLine("Test case 3: Max string is at third position");
            string maxString3 = FindMax<string>("apple", "banana", "cherry");
            Console.WriteLine("Max string is: " + maxString3); 
        }

        static T FindMax<T>(T a, T b, T c) where T : IComparable
        {
            T max = a;
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
