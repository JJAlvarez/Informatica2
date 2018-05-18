using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface ITablero
    {
        int Capacidad { get; set; }

        bool ColocarBarco(IBarco barco);
        bool Atacar(int x, int y);
        bool EstaConcluido();

    }
}
