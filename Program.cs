namespace Generics;
    class Program
    {
        static void Main()
        {
            TestMaximum(9, 2, 1);
            TestMaximum(25.5f, 53.2f, 68.9f, -3.4f);
            TestMaximum("apple", "banana", "cherry", "date");
        }

        static void TestMaximum<T>(T a, T b, params T[] args) where T : IComparable
        {
            T max = FindMax(a, b, args);
            PrintMax(max);
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

        static void PrintMax<T>(T max)
        {
            Console.WriteLine("Max value is: " + max);
        }
    }
}
