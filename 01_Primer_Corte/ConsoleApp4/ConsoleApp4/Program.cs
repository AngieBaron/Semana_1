﻿using System;
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
            float kilometros = 0;
            float resultado = 0;

            
            Console.WriteLine("Escriba los kilometros recorridos ");
            kilometros = float.Parse(System.Console.ReadLine());
            resultado = ((COSTO) * kilometros);
            Console.WriteLine("El resultado es {0}", resultado);


        }



    }


}
