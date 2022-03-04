
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
            int opcion=0,dias=0;
            
            Console.WriteLine("1-");
            Console.WriteLine("2-");
            Console.WriteLine("3-");
            Console.WriteLine("4-");
            Console.WriteLine("5-");
            Console.WriteLine("6-");
            Console.WriteLine("7-");
            Console.WriteLine("8-");
            Console.WriteLine("9-");
            Console.WriteLine("10-");
            Console.WriteLine("11-");
            Console.WriteLine("12-");
            opcion = int.Parse(System.Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (dias == 31) ;
                    Console.WriteLine("el mes es enero tiene 31 dias");
                    break;
                case 2:
                    if (dias ==28) ;
                    Console.WriteLine("el mes es febrero tiene 28 dias");
                    break;
                case 3:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es marzo tiene 31 dias");
                    break;
                case 4:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es abril tiene 31 dias");
                    break;
                case 5:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es mayo tiene 31 dias");
                    break;
                case 6:
                    if (dias ==30) ;
                    Console.WriteLine("el mes es junio tiene 30 dias ");
                    break;
                case 7:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es julio tiene 31 dias");
                    break;
                case 8:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es agosto tiene 31 dias");
                    break;
                case 9:
                    if (dias ==30) ;
                    Console.WriteLine("el mes es septiembre tiene 30 dias");
                    break;
                case 10:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es octubre tiene 31 dias ");
                    break;
                case 11:
                    if (dias ==30) ;
                    Console.WriteLine("el mes es noviembre tiene 30 dias");
                    break;
                case 12:
                    if (dias ==31) ;
                    Console.WriteLine("el mes es diciembre tiene 31 dias");
                    break;
            }
            } 
        }
    }
         

