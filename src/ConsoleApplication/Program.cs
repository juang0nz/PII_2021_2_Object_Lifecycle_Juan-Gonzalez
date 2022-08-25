//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
           /* var train = new Train ();
            train.StartEngines();
            Console.WriteLine("Hello World!");*/
            int i = 1;
            while (i<=100)
            {
              Train Trencito = new Train ("Orient Express");
              i++;
            }
            //prueba con 10.000
           /* int e = 1;
            while (e<=10000)
            {
              Train t1 = new Train ("Orient Express Plus");
              e++;
            }*/

            //Cuando ejecute las 10.000 instancias de trenes, llego a un punto donde se utiliza el método destructor. Esto debe ser por el lugar
            //en la memoria.

            //parte 9 del ejercicio:

            Train t1 = new Train ("Last Train To London");
            Train t2 = new Train ("Last Train To London");
            Train t3 = new Train ("Runaway Train");
             Console.WriteLine(t1 == t2); // da FALSE, debido a que si bien tienen los mismos atributos no son el mismo objeto. ahi estoy comparando obj.
             Console.WriteLine(t2 == t3);//da FALSE,  no son el mismo objeto. ahi estoy comparando obj.

        }
    }
}