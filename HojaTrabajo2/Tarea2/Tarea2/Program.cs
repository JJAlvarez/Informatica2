using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona Persona1 = new Persona();
            Persona Persona2 = new Persona();

            QueHacer queHacer1= new QueHacer("Lavar trastos", new DateTime(), "Lavar los trastos de la casa");
            QueHacer queHacer2 = new QueHacer("Barrer", new DateTime(), "Barrer el piso de la casa");
            QueHacer queHacer3 = new QueHacer("Pasear perro", new DateTime(), "Pasear al perro por el parque");
            QueHacer queHacer4 = new QueHacer("Trapear", new DateTime(), "Trapear el piso de la casa");
            QueHacer queHacer5 = new QueHacer("Lavar el bano", new DateTime(), "Lavar el bano de la casa");
            QueHacer queHacer6 = new QueHacer("Cocinar", new DateTime(), "Cocinarle a leo");

            Persona1.AgregarQueHacer(queHacer1);
            Persona1.AgregarQueHacer(queHacer2);
            Persona1.AgregarQueHacer(queHacer3);

            Persona2.AgregarQueHacer(queHacer4);
            Persona2.AgregarQueHacer(queHacer5);
            Persona2.AgregarQueHacer(queHacer6);

            Persona1.CompletarQueHacer();

            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();
            Persona2.CompletarQueHacer();

            Console.WriteLine("Persona uno esta disponible? => " + Persona1.EstaDisponible());
            Console.WriteLine("Persona dos esta disponible? => " + Persona2.EstaDisponible());
            Console.ReadLine();
        }
    }
}
