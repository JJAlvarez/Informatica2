class Ejemplo
{
    public static object Head(object[] arreglo)
    {
        return arreglo[0];
    }

    public static T HeadGenerico<T>(T[] arreglo)
    {
        return arreglo[0];
    }

    public static void Prueba()
    {
        //Hay un grave error ya que el programa lanzara una excepcion en tiempo
        //de ejecucion al intentar castear una cadena a un entero
        string[] valores = new string[] { "hola", "mundo" };
        int respuesta = (int)Head(valores);

        //A diferencia del metodo generico, el cual me permite mantener un control 
        //del tipo de dato que se obtendra y no hay mas necesidad de seguir
        //casteando los objetos
        int[] valoresInt = new int[] { 1, 2, 3, 4 };
        int respuestaint = HeadGenerico(valoresInt);
    }
}
