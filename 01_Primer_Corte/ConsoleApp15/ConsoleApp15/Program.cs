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
            int sumarpar = 0;
            int sumarimpar= 0;
            int contadorpar = 0;
            int sumaimpar=0;
            int contadorimpar = 0;


            Console.WriteLine("digite un numero");
            contador = int.Parse(System.Console.ReadLine());

            for (int numero = 0; numero < 10; numero++)
                if(contador % 10== 0);





            if (contador > 0 || contador < 0)

                {
                    Console.WriteLine("digite un numero");
                    contador = int.Parse(System.Console.ReadLine());
                    contadorpar = contadorpar +1;
                    sumarpar = sumarpar + contador;
                }
            else
            {
                    sumarimpar = sumarimpar +1;
                    sumarimpar = sumarimpar + contador;
                }
            if (contador % 2 == 0) ;

            Console.WriteLine("los numero pares son {0}:",sumarpar);
            Console.WriteLine("los numero impares son {0}:",sumarimpar);
           
        }
    }
}
//if (contador < 0)
//{
//Console.WriteLine("digite un numero");
//contador = int.Parse(System.Console.ReadLine());
// contador++;
// }