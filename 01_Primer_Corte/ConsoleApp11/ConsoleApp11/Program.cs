using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio9
{
    class program
    {
        static void Main(string[] args)
        {

            double EdadPersona;
            double EdadPerro;
            Console.WriteLine("Digita La Edad De La Persona");
            EdadPersona = float.Parse(System.Console.ReadLine());
            if (EdadPersona <= 2)
            {
                EdadPerro = (EdadPersona * 10.5);
            }
            else
            {
                EdadPerro = (EdadPersona - 2) *( 4) + (10.5 * 2);
            }
            System.Console.WriteLine("Le Edad Del Perro Es {0}", EdadPerro);

        }
    }
}