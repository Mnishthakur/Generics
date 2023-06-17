namespace Generics;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test case 1: Max number is at first position");
            var intFinder = new Finder<int>(9, 2, 1);
            int maxInt1 = intFinder.TestMaximum();
            Console.WriteLine("Max number is: " + maxInt1); 

            Console.WriteLine("Test case 2: Max number is at second position");
            var floatFinder = new Finder<float>(25.5f, 53.2f, 68.9f);
            float maxFloat2 = floatFinder.TestMaximum();
            Console.WriteLine("Max number is: " + maxFloat2);

            Console.WriteLine("Test case 3: Max string is at third position");
            var stringFinder = new Finder<string>("apple", "banana", "cherry");
            string maxString3 = stringFinder.TestMaximum();
            Console.WriteLine("Max string is: " + maxString3);
        }
    }

    class Finder<T> where T : IComparable
    {
        private T a;
        private T b;
        private T c;

        public Finder(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public T TestMaximum()
        {
            return FindMax(a, b, c);
        }

        private static T FindMax(T a, T b, T c)
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
