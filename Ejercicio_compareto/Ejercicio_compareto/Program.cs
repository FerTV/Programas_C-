﻿using System;

namespace Ejercicio_compareto
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1, cadena2;

            Console.Write("Introduce la cadena1: ");
            cadena1 = Console.ReadLine();
            Console.Write("Introduce la cadena2: ");
            cadena2 = Console.ReadLine();
            
            //usamos compare NO COMPARETO!!!
            if (String.Compare(cadena1, cadena2, true) > 0)
                Console.WriteLine("La cadena 1 es mayor que la cadena 2");
            else
            {
                if (String.Compare(cadena1, cadena2, true) < 0)
                    Console.WriteLine("La cadena 2 es mayor que la cadena 1");
                else
                    Console.WriteLine("Las dos cadenas son iguales");
            }
        }
    }
}
