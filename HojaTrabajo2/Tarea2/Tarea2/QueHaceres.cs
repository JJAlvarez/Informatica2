using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class QueHaceres
    {

        public List<QueHacer> ListaTareas { get; set; }

        public QueHaceres()
        {
            ListaTareas = new List<QueHacer>();
        }

        public void AgregarTarea(QueHacer queHacer)
        {
            ListaTareas.Add(queHacer);
        } 

        public void CompletarQueHacer()
        {
            for (int i = ListaTareas.Count - 1; i >= 0; i--)
            {
                if (ListaTareas[i].Estado == Estado.EnProgreso)
                {
                    ListaTareas[i].Completar();
                    break;
                }
            }
        } 
        
        public bool EstaDisponible()
        {
            for (int i = 0; i < ListaTareas.Count; i++)
            {
                if (ListaTareas[i].Estado == Estado.EnProgreso)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
