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

            int contador = 0;
            int positivo = 0;
            int negativo = 0;


            Console.WriteLine("digite un numero");
            contador = int.Parse(System.Console.ReadLine());

            for (int numero = 0; numero < 10; numero++)
                if (contador > 0)
                    Console.WriteLine("digite un numero");
            contador = int.Parse(System.Console.ReadLine());


            if (contador < 0)

                Console.WriteLine("digite un numero");
            contador = int.Parse(System.Console.ReadLine());
        }          
    }
}       



        

    


