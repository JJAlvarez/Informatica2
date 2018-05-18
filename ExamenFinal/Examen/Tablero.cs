using System.Collections.Generic;

namespace Examen
{
    public class Tablero : ITablero
    {
        public int Capacidad { get; set; }
        private List<IBarco> Barcos { get; set; }

        public Tablero(int capacidad)
        {
            Capacidad = capacidad;
            Barcos = new List<IBarco>();
        }

        public bool Atacar(int x, int y)
        {
            foreach (var item in Barcos)
            {
                if (item.X == x && item.Y == y)
                {
                    item.Atacar(0);
                    return true;
                }

                if (item.X == x)
                    if ((item.Y + item.Longitud) >= y && item.Orientacion == 2)
                    {
                        item.Atacar((item.Y + item.Longitud) - y);
                        return true;
                    }

                if (item.Y == y)
                    if ((item.X + item.Longitud) >= x && item.Orientacion == 1)
                    {
                        item.Atacar((item.X + item.Longitud) - x);
                        return true;
                    }
            }
            return false;
        }

        public bool ColocarBarco(IBarco barco)
        {
            if (Barcos.Count <= Capacidad)
            {
                foreach (var item in Barcos)
                {
                    if (item.X == barco.X && item.Y == barco.Y)
                        return false;

                    if (item.X == barco.Y)
                        if ((item.X + item.Longitud) >= barco.X && item.Orientacion == 1)
                            return false;

                    if (item.Y == barco.X)
                        if ((item.Y + item.Longitud) >= barco.Y && item.Orientacion == 2)
                            return false;
                }
                Barcos.Add(barco);
                return true;

            } else
            {
                return false;
            }
        }

        public bool EstaConcluido()
        {
            foreach (var item in Barcos)
            {
                if (!item.EstaHundido())
                    return false;
            }
            return true;
        }
    }
}
