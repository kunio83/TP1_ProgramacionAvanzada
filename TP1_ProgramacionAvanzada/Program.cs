using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ProgramacionAvanzada
{
    class Program
    {
        static void Main(string[] args)
        {

            //ImprimirEnum();
            var a = (int)314.4;
            Console.WriteLine(a);
            Console.ReadLine();
        }

        // 1)Crear una función que devuelva la suma de dos números recibidos por parámetros
        public static int Sumar(int numeroA, int numeroB)
        {
            return numeroA + numeroB;
        }

        // 2)Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
        public static string Recortar(string cadena)
        {
            return cadena.Substring(0, 4);
        }

        // 3)Crear una función que devuelva la fecha y hora actual
        public static DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;

        }

        /*
        public static DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }
        */

        // 2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana
        public static void ImprimirEnum()
        {
            Console.WriteLine(DiaSemana.Domingo);
            Console.WriteLine(DiaSemana.Lunes);
            Console.WriteLine(DiaSemana.Martes);
        }

        // 1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados.
        public static void Convertir()
        {
            string stringTrue = "true";
            string stringFalse = "false";
            int intTrue = 1;
            int intFalse = 0;

            bool resultConvertTrue = Convert.ToBoolean(stringTrue);
            bool resultBoolParseTrue = bool.Parse(stringTrue);

        }
    }
}
