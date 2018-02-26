using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    public class Genericos
    {

        public static T Head<T>(T[] arreglo)
        {
            return arreglo[0];
        }

        public static T[] Tail<T>(T[] arreglo)
        {
            List<T> temp = arreglo.ToList();
            temp.RemoveAt(0);
            T[] arregloNuevo = temp.ToArray<T>();

            return arregloNuevo;
        }

        public static Tupla<T1, T2>[] Zip<T1, T2>(T1[] primero, T2[] segundo)
        {
            Tupla<T1, T2>[] arreglo = new Tupla<T1, T2>[primero.Length < segundo.Length ? primero.Length : segundo.Length];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = new Tupla<T1, T2>(primero[i], segundo[i]);
            }

            return arreglo;
        }
    }
}
