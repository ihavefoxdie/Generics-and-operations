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
            Console.WriteLine("int sum of 5 and 5 result: " + GenericMethods.SumOf<int, GenericMethods.IntAdd>(5, 5));
            Console.WriteLine("string sum of \"string is\" and \" added\" result: " + GenericMethods.SumOf<string, GenericMethods.StringAdd>("string is", " added"));
            Console.WriteLine("largest int value of given parameters result: " + GenericMethods.MValue<int, GenericMethods.IntComp>(3, 4, 5, 6, 10, 2, 199));
            Console.WriteLine("largest int value of given parameters result: " + GenericMethods.MValue<double, GenericMethods.DoubleComp>(3.5, 4, 5, 6, 10.73, 10.735, 0.199));

        }
    }
}