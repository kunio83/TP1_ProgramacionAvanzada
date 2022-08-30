using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ProgramacionAvanzada
{
    public class Practica
    {
        static void Main(string[] args)
        {

            //ImprimirEnum();
            //var a = (int)314.4;
            int a = 443444;
            short b = (short)a;
            Console.WriteLine(b);
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

            // true
            bool resultConvertStringTrue = Convert.ToBoolean(stringTrue); //<-- Utiliza la clase Convert 
            bool resultBoolParseTrue = bool.Parse(stringTrue); //<-- Utiliza un extension method implementado dentro del tipo bool
            bool resultBoolTryParseStringTrue;
            bool.TryParse(stringTrue, out resultBoolTryParseStringTrue); //<-- Utiliza un extension method implementado dentro del tipo bool guardando el resultado en una variable previamente definida. El TryParse devuelve un booleano indicando si se pudo o no hacer el parseo.

            // false
            bool resultConvertStringFalse = Convert.ToBoolean(stringFalse);
            bool resultBoolParseFalse = bool.Parse(stringFalse);
            bool resultBoolTryParseStringFalse;
            bool.TryParse(stringFalse, out resultBoolTryParseStringFalse);

            // 1
            bool resultConvertIntTrue = Convert.ToBoolean(intTrue);
            //bool resultBoolParseFalse = bool.Parse(intFalse); //<--solo acepta strings
            bool resultBoolTryParseIntTrue;
            bool.TryParse(stringTrue, out resultBoolTryParseIntTrue);

            // 0
            bool resultConvertIntFalse = Convert.ToBoolean(intFalse);
            //bool resultBoolParseFalse = bool.Parse(intFalse); //<--solo acepta strings
            bool resultBoolTryParseIntFalse;
            bool.TryParse(stringFalse, out resultBoolTryParseIntFalse);
        }

        //3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.
        public static void ImprimirColor(Color color)
        {
            switch (color)
            {
                case Color.Verde:
                    {
                        Console.WriteLine(Color.Verde);
                    }
                    break;
                case Color.Amarillo:
                    {
                        Console.WriteLine(Color.Amarillo);
                    }
                    break;
                case Color.Rojo:
                    {
                        Console.WriteLine(Color.Rojo);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("!?");
                    }
                    break;
            }
        }

        //4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. 
        // 5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.
        public static void EsMayor(int a)
        {
            if (a > 10)
            {
                Console.WriteLine("a es mayor a 10");
            }
            else
            {
                Console.WriteLine("ERROR -> a NO es mayor a 10");
            }
        }

        //7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar.
        public static void Incrementar()
        {
            int contador = 0;

            while (contador <= 50)
            {
                contador = contador + 5;
            }
        }
    }
}
