using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Bucles.Servicios
{
    internal class MostrarNumerosImplementacion : MostrarNumerosInterfaz
    {

        public void mostrarNumeros(int numero)
        {
            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
