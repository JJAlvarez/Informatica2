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

        public abstract void Push(T obj);

        public abstract bool Set(int i, T obj);

        public void Push(IList<T> list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                T nuevo = new T();
                list.Get(i, out nuevo);
                Push(nuevo);
            }
        }

        public abstract bool Get(int i, out T obj);
    }
}
