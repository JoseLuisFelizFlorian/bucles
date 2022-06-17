using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles
{
    internal class Practica3
    {
        public void practica3()
        {
            Console.WriteLine("Problema #3: Programa que imprima los números impares entre el 1 y el 1000;");
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
