namespace Generics;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test case 1: Max string is at first position");
            string max1 = FindMax("Apple", "Peach", "Banana");
            Console.WriteLine("Max string is: " + max1); // 

            Console.WriteLine("Test case 2: Max string is at second position");
            string max2 = FindMax("Dog", "Elephant", "Cat");
            Console.WriteLine("Max string is: " + max2); //

            Console.WriteLine("Test case 3: Max string is at third position");
            string max3 = FindMax("Green", "Red", "Yellow");
            Console.WriteLine("Max string is: " + max3); //
        }

        static string FindMax(string a, string b, string c)
        {
            string max = null;
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

