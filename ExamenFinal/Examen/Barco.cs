using System;

namespace Examen
{
    public class Barco : IBarco
    {
        public int Longitud { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Orientacion { get; set; }

        private int[] Espacios;
        
        public Barco(int longitud, int x, int y, int orientacion)
        {
            Longitud = longitud;
            X = x;
            Y = y;
            if (orientacion == 1 || orientacion == 2)
                Orientacion = orientacion;
            else
                throw new Exception();

            Espacios = new int[longitud];
        }

        public bool Atacar(int proyectil)
        {
            if (Espacios.Length >= proyectil)
            {
                if (Espacios[proyectil] == 0)
                {
                    Espacios[proyectil] = 1;
                    return true;
                } else
                {
                    return false;
                }
            }
            return false;
        }

        public bool EstaHundido()
        {
            foreach (int item in Espacios)
            {
                if (Espacios[item] == 0)
                    return false;
            }
            return true;
        }
    }
}
