using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace AplicacionBase
{
    class program
    {
        static void Main(string[] args)
        {
            
            double PI = 3.14;
            double diametro = 0;
            double resultado = 0;

            Console.WriteLine("escriba el diametro del circulo");
            diametro = float.Parse(System.Console.ReadLine());
            resultado =PI * diametro;
            Console.WriteLine("la circunferencia es{0}",resultado);
            
        }
    }
}