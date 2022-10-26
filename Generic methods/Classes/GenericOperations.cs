using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        public static T SumOf<T, C>(T a, T b) where C : IAdd<T>, new()
        {
            C calc = new();
            return calc.Add(a, b);
        }

        public static T MValue<T, C>(params T[] values) where C: IComparer<T>, new()
        {
            T max = values[0];
            C comp = new();
            for(int i = 1; i < values.Length; i++)
            {
                if (comp.Compare(max, values[i]) == 1)
                    continue;
                else
                    max = values[i];
            }

            return max;
        }
        
        public class IntComp : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                return a < b ? -1 : 1;
            }
        }

        public class DoubleComp : IComparer<double>
        {
            /*double Compare(double a, double b)
            {
                return a < b ? b : a;
            }*/

            int IComparer<double>.Compare(double a, double b)
            {
                return Comparer<double>.Default.Compare(a, b);
            }
        }

        public class IntAdd : IAdd<int>
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            /*static public Int32Add operator +(Int32Add a, Int32Add b)
            {
                return new Int32Add(a._value + b._value);
            }*/
        }

        public class DoubleAdd : IAdd<double>
        {
            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        public class StringAdd : IAdd<string>
        {
            public string Add(string a, string b)
            {
                return a + b;
            }
        }


    }

    
}
