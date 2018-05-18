using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface IBarco
    {
        int Longitud { get; set; }
        int X { get; set; }
        int Y { get; set; }
        int Orientacion { get; set; }

        bool Atacar(int proyectil);
        bool EstaHundido();

    }
}
