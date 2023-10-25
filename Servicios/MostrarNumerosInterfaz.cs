using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Bucles.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de mostrar la secuencia de números hasta llegar al introducido
    /// 251023 - MDN
    /// </summary>
    internal interface MostrarNumerosInterfaz
    {
        /// <summary>
        /// Método para mostrar el patron de números hasta llegar al introducido por el usuario
        /// 251023 - MDN
        /// </summary>
        /// <returns></returns>
        public void mostrarNumeros(int numero);
    }
}
