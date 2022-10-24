using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_methods.Interfaces
{
    public interface IAdd<T>
    {
        T DefVal { get; }
        T Add(T a, T b);
    }
}
