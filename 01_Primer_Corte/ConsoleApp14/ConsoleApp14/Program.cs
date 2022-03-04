using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Caliificacion
{
    class program
    {
        static void Main(string[] args)
        {
            double Base= 0, altura= 0,radio=0,opcion=0,resultado=0,largo=0,ancho=0,NUMERO=2;
            double PI = 3.1415;

            Console.WriteLine("1-areaparalelogramo");
            Console.WriteLine("2-areacircunferencia");
            Console.WriteLine("3-areaparalelepipedo");
            Console.WriteLine("que area quiere realizar");
            opcion = double.Parse(System.Console.ReadLine());
           

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("digite la base");
                    Base=double.Parse(System.Console.ReadLine());
                    Console.WriteLine("digite la altura");
                    altura = double.Parse(System.Console.ReadLine());
                    resultado = Base * altura;
                    break;
                case 2:
                    Console.WriteLine("digite PI");
                    PI = double.Parse(System.Console.ReadLine());
                    Console.WriteLine("digite el radio");
                    radio = double.Parse(System.Console.ReadLine());
                    resultado = PI * radio*radio;
                    break;
                case 3:
                    Console.WriteLine("digite altura");
                    altura= double.Parse(System.Console.ReadLine());
                    Console.WriteLine("digite el largo");
                    largo = double.Parse(System.Console.ReadLine());
                    Console.WriteLine("digite ancho");
                    ancho= double.Parse(System.Console.ReadLine());
                    Console.WriteLine("digite el radio");
                    radio = double.Parse(System.Console.ReadLine());
                    resultado = (altura*largo+largo*ancho+altura*ancho);
                    break;
            }
            Console.WriteLine(" el area es{0}",resultado);

        }
    }
}

