namespace Generics;
    {
        static void Main()
        {
            Console.WriteLine("Test case 1: Max number is at first position");
            int maxInt1 = FindMax(9, 2, 1);
            Console.WriteLine("Max number is: " + maxInt1); // Output: Max number is: 9

            Console.WriteLine("Test case 2: Max number is at second position");
            float maxFloat2 = FindMax(25.5f, 53.2f, 68.9f, -3.4f);
            Console.WriteLine("Max number is: " + maxFloat2); // Output: Max number is: 68.9

            Console.WriteLine("Test case 3: Max string is at third position");
            string maxString3 = FindMax("apple", "banana", "cherry", "date");
            Console.WriteLine("Max string is: " + maxString3); // Output: Max string is: date
        }

        static T FindMax<T>(T a, T b, params T[] args) where T : IComparable
        {
            T[] arr = new T[args.Length + 2];
            arr[0] = a;
            arr[1] = b;
            Array.Copy(args, 0, arr, 2, args.Length);
            Array.Sort(arr);
            return arr[^1];
        }
    }
}
