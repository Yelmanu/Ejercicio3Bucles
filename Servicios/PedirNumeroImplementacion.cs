using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Bucles.Servicios
{
    internal class PedirNumeroImplementacion : PedirNumeroInterfaz
    {
        /// <summary>
        /// Método que pide el número por consola al usuario
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public int pedirNumero()
        {
            Console.WriteLine("Introduce un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
    }
}
