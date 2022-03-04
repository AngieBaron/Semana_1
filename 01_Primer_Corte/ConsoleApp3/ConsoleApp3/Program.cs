using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace area
{
    class program
    {
        static void Main(string[] args)
        {
            float COSTO = 1280;
            float kilometros= 0;
            float area = 0;
            float valor = 0;

            Console.WriteLine("por favor ingrese es COSTO ");
            COSTO = float.Parse(System.Console.ReadLine());
            Console.WriteLine("digite los kilometros recorridos");
            kilometros = float.Parse(System.Console.ReadLine());
            valor = COSTO * kilometros;
            Console.WriteLine("El valor es {0}", valor);


        }



    }


}
