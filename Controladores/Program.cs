using Ejercicio3Bucles.Servicios;

namespace Ejercicio3Bucles.Controladores
{
    class Program
    {
        static public void Main(string[] args)
        {
            //Declaramos las variables
            int numero;

            //Instanciamos las clases donde se encuentran nuestros metodos
            PedirNumeroInterfaz pni = new PedirNumeroImplementacion();
            MostrarNumerosInterfaz mni = new MostrarNumerosImplementacion();

            //Pedimos el número por consola
            numero = pni.pedirNumero();

            //Realizamos la muestra de la secuencia de números hasta el número introducido
            mni.mostrarNumeros(numero);
        }
    }
}
