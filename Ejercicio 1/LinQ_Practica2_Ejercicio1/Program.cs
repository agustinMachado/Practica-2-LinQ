using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Practica2_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona { Nombre = "Juan", Edad = 25, Ciudad = "Lima" },
                new Persona { Nombre = "María", Edad = 30, Ciudad = "Bogotá" },
                new Persona { Nombre = "Pedro", Edad = 35, Ciudad = "Madrid" },
                new Persona { Nombre = "Ana", Edad = 20, Ciudad = "Lima" },
                new Persona { Nombre = "José", Edad = 40, Ciudad = "Buenos Aires" }
            };
            

            var consulta = from p in personas where p.Edad < 25 && p.Ciudad == "Lima" orderby p.Nombre descending select new { p.Nombre, p.Edad };

            foreach (var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }

            // Punto i)
            var consulta2 = from p in personas where p.Edad > 30 && p.Ciudad == "Bogotá" orderby p.Nombre descending select new { p.Nombre, p.Edad };
            foreach (var persona in consulta2)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }

            //Punto ii)
            var consulta3 = from p in personas where p.Edad > 25 && p.Edad < 35 orderby p.Edad ascending select new { p.Nombre, p.Edad };
            foreach (var persona in consulta3)
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años");
            }

        }
    }
}
