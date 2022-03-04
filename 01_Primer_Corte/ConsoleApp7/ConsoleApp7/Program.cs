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
            string entrada = "";
            float PI = 3.14f;
            float Radio = 0.0f;
            float Area = 0.0f;
    

            Console.WriteLine("");
            Console.WriteLine("Regalame el valor del radio");
            Radio = float.Parse(System.Console.ReadLine());
            Area = PI * (Radio * Radio);
            Console.WriteLine("El radio es [0] y el area de una circunferencia es [1]", Radio, Area);
        }
    }
}
