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
            float lado = 0, apotema = 0, area = 0;


            Console.WriteLine("por favor ingrese un lado del hexagono ");
            lado = float.Parse(System.Console.ReadLine());     
            Console.WriteLine("digita el apotema del hexagono");
            apotema = float.Parse(System.Console.ReadLine());
            area = (((lado * 6) * apotema) / 2);
            Console.WriteLine("El area es {0}", area);


        }



    }


}
