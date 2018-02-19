namespace Programas
{
    public class ArrayList<T> : Lista<T> where T: new()
    {

        private T[] Almacenamiento { get; set; }

        public override int Length { get => Almacenamiento.Length; }

        public ArrayList(T[] arreglo)
        {
            Almacenamiento = arreglo;
        }

        public override void Push(IList<T> list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                T nuevo = new T();
                Get(i, out nuevo);
                Push(nuevo);
            }
        }

        public override void Push(T obj)
        {
            T[] temp = new T[Almacenamiento.Length + 1];
            for (int i = 0; i < Almacenamiento.Length; i++)
            {
                temp[i] = Almacenamiento[i];
            }
            temp[temp.Length - 1] = obj;
            Almacenamiento = temp;
        }

        //public override bool Get(int i, out int i2)
        //{
        //    i2 = 0;
        //    if (i >= Length)
        //    {
        //        return false;
        //    } else
        //    {
        //        i2 = i;
        //        return true;
        //    }
        //}

        public override bool Set(int i, T obj)
        {
            if (i >= Length)
                return false;

            Almacenamiento[i] = obj;
            return true;
        }

        public override bool Get(int i, out T obj)
        {
            obj = new T();
            if (i >= Length)
            {
                return false;
            }
            else
            {
                obj = Almacenamiento[i];
                return true;
            }
        }
    }
}
