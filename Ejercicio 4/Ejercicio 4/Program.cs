using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte a)

            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotal = 0;

            foreach (var valor in valores)
            {
                sumaTotal += valor;
            }

            Console.WriteLine($"La suma total es: {sumaTotal}");


            //Funcion LinQ
            int suma = valores.Sum();
            Console.WriteLine($"La suma total es: {suma}");



            //Parte b)

            List<int> valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotalValoresPares = 0;

            foreach(var valor in valores2)
            {
                if(valor % 2 == 0)
                {
                    sumaTotalValoresPares += valor;
                }
            }

            Console.WriteLine($"La suma total de los valores pares es: {sumaTotalValoresPares}");


            //Funcion LinQ
            List<int> sumaPares = valores2.Where(x => x % 2 == 0).ToList();
            int sumaValoresPares = sumaPares.Sum();
            Console.WriteLine($"La suma total de los valores pares es: {sumaValoresPares}");

            // Otra forma
            //IEnumerable<int> numeros = from numero in valores where numero % 2 == 0 select numero;
            //int suma = 0;

            //foreach (var num in numeros)
            //{
            //    suma += num;
            //}

            //Console.WriteLine($"La suma total de los valores pares es: {suma}");
        }
    }
}
