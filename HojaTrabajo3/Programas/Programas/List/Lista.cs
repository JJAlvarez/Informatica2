using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas
{
    public abstract class Lista<T> : IList<T> where T : new()
    {
        public abstract int Length { get; }

        //public abstract bool Get(int i, out int i2);

        public abstract void Push(T obj);

        public abstract bool Set(int i, T obj);

        public abstract void Push(IList<T> list);

        public abstract bool Get(int i, out T obj);
    }
}
