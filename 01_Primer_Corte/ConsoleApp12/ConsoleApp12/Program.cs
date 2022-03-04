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
            int nota1,nota2,nota3,nota4;
            int matematicas, ingles, español, fisica;
            int estudiante1, estudiante2, estudiante3, estudiante4, estudiante5;

            Console.WriteLine("digite nota de matematicas de 1 a 100  del primer estudiante ");
            nota1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de matematicas de 1 a 100  del segundo estudiante ");
            nota2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de matematicas de 1 a 100  del tercer estudiante ");
            nota3 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de matematicas de 1 a 100  del cuarto estudiante ");
            nota4 = int.Parse(System.Console.ReadLine());

            if (nota1 < 50)
            {
                Console.WriteLine("la nota de matemicas del primer estudiante es insuficiente",nota1);
            }
            Console.WriteLine("la nota {0}", MAXIMA_CALIFICACION);

            Console.WriteLine("digite nota de ingles de 1 a 100  del primer estudiante ");
            nota1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de ingles de 1 a 100  del segundo estudiante ");
            nota2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de ingles de 1 a 100  del tercer estudiante ");
            nota3 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de ingles de 1 a 100  del cuarto estudiante ");
            nota4 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("digite nota de español de 1 a 100  del primer estudiante ");
            nota1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de español de 1 a 100  del segundo estudiante ");
            nota2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de español de 1 a 100  del tercer estudiante ");
            nota3 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de español de 1 a 100  del cuarto estudiante ");
            nota4 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("digite nota de fisica de 1 a 100  del primer estudiante ");
            nota1 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de fisica de 1 a 100  del segundo estudiante ");
            nota2 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de fisica de 1 a 100  del tercer estudiante ");
            nota3 = int.Parse(System.Console.ReadLine());
            Console.WriteLine("digite nota de fisica de 1 a 100  del cuarto estudiante ");
            nota4 = int.Parse(System.Console.ReadLine());

            if (nota1 < 50)
            {
                Console.WriteLine("la nota de matemicas del estudiante 1 es insuficiente");
            }


















        }



    }


}