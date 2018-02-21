using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas
{
    public interface IList<T> where T: new()
    {
        bool Set(int i, T obj);
        void Push(T obj);
        int Length { get; }
        bool Get(int i, out T obj);
    }
}
