using System;
using Generic_methods.Classes;

namespace Testing
{
    static class Program
    {
        static void Main()
        {
            int a = 5, b = 6;

            Console.WriteLine("Swap generic method:\n");
            Console.WriteLine("Before: " + a + " " + b);
            GenericMethods.Swap(ref a, ref b);
            Console.WriteLine("After: " + a + " " + b);
            Console.WriteLine("Sum generic method:\n");
            Int32Add ass = new();
            Console.WriteLine("result: " + GenericMethods.SumOf(5, ass));
        }
    }
}