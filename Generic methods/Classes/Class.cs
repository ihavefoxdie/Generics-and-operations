using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generic_methods.Interfaces;

namespace Generic_methods.Classes
{
    public class GenericMethods
    {

        public static void Swapper<T>(ref T arg1, ref T arg2)
        {
            var temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }

        public void Som<T>(params T[] values)
        {
            object ass = values;
            SumOf(ass);
        }
        public static T SumOf<T>(params T[] values)
        {
            if (typeof(T) == typeof(Int32))
            {
                int result = 0;
                int[] val = new int[values.Length];
                for(int i = 0; i < val.Length; i++)
                {
                    val[i] = Convert.ToInt32(values[i]);
                    result += val[i];
                }
                object o = result;
                return (T)o;
            }
            if (typeof(T) == typeof(double))
            {
                double result = 0;
                double[] val = new double[values.Length];
                for (int i = 0; i < val.Length; i++)
                {
                    val[i] = Convert.ToDouble(values[i]);
                    result += val[i];
                }
                object o = result;
                return (T)o;
            }
            if (typeof(T) == typeof(string))
            {
                string result = "";
                string[] val = new string[values.Length];
                for (int i = 0; i < val.Length; i++)
                {
                    val[i] = Convert.ToString(values[i]);
                    result += val[i];
                }
                object o = result;
                return (T)o;
            }
            else
                throw new Exception("uhm");
        }

        public class Int32Add : IAdd<int>
        {
            public static readonly Int32Add Instance = new Int32Add();
            public int DefVal { get { return 0; } }
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        public class DoubleAdd : IAdd<double>
        {
            public static readonly DoubleAdd Instance = new DoubleAdd();
            public double DefVal { get { return 0; } }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        public class StringAdd : IAdd<string>
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
