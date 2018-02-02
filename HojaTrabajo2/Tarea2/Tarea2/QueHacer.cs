using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public enum Estado
    {
        EnProgreso,
        Terminado
    }

    public class QueHacer
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Estado Estado { get; private set; }

        public void Completar()
        {
            Estado = Estado.Terminado;
        }

        public QueHacer(string nombre, DateTime fecha, string descripcion)
        {
            Fecha = fecha;
            Nombre = nombre;
            Descripcion = descripcion;
            Estado = Estado.EnProgreso;
        }
    }
}
