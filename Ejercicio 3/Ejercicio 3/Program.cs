using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (var indice = 0; indice < valores.Count - 1; indice++)
            {
                if (valores[indice] > valores[indice + 1])
                {
                    var valorTemporal = valores[indice];

                    valores[indice] = valores[indice + 1];
                    valores[indice + 1] = valorTemporal;

                    indice = -1;
                }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }

            //COMPLEJIDAD COGNITIVA = 5

            //Funcion LinQ
            List<int> valoresOrdenados = valores.OrderBy(valor => valor).ToList();
            foreach(int valor in valoresOrdenados)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
