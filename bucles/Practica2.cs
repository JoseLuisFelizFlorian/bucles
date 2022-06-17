
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles
{
    internal class Practica2
    {
        public void practica2()
        {
            Console.WriteLine("Problema #2 : Programa que imprima las tablas de multiplicar 2-9.");
            for (int i = 2; i <= 9; i++)
            {
                //las lineas de los ** se usan como ecoracion y separadores entre las tablas 
                Console.WriteLine("*************************************");
                Console.WriteLine("Tabla del " + i);
                Console.WriteLine("*************************************");

                for (int e = 1; e <= 10; e++)
                {
                    Console.WriteLine(i + " x " + e + "= " + i * e);
                }
            }
        }
    }
}