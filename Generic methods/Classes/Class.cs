using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_methods.Interfaces;

namespace Generic_methods.Classes
{
    public class GenericMethods<T> : IAdd<T>
    {
        
        public static void Swapper<T>(ref T arg1, ref T arg2)
        {
            var temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        public static T SumOff<T>(params T[] values)
        {
            
            T result = default(T);

            foreach (var item in values)
            {
                result = ass.Add(result, item);
            }

            return result;
        }

        public class Int32Add : IAdd<Int32>
        {
            public static readonly Int32Add Instance = new Int32Add();
            public int DefVal { get { return 0; } }
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        class DoubleAdd : IAdd<double>
        {
            public static readonly DoubleAdd Instance = new DoubleAdd();
            public double DefVal { get { return 0; } }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        class StringAdd : IAdd<string>
        {
            public static readonly StringAdd Instance = new StringAdd();
            public string DefVal { get { return ""; } }

            public string Add(string a, string b)
            {
                return a + b;
            }

        }


    }

    
}
