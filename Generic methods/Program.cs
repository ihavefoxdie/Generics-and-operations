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
            GenericMethods.Swapper(ref a, ref b);
            Console.WriteLine("After: " + a + " " + b);
            Console.WriteLine("Sum generic method:\n");
            Console.WriteLine("result: " + GenericMethods.SumOf<int, GenericMethods.IntAdd>(5, 5));
            Console.WriteLine("result: " + GenericMethods.SumOf<string, GenericMethods.StringAdd>("string is", " added"));

        }
    }
}