public interface IBinTree{
    int Valor {get;}

    IBinTree Derecho {get;}

    IBinTree Izquierdo {get;}

    int Sumar();

    int[] ToArray();

    void Insert(int value);
}