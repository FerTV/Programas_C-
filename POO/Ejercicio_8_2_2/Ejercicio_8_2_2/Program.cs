﻿using System;
using System.IO;

namespace Ejercicio_8_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";

            using (StreamWriter fichero = new StreamWriter("registroDeUsuario.txt"))
            {
                while (frase.ToLower() != "fin")
                {
                    if (frase != "")
                    {
                        fichero.WriteLine(frase);
                    }
                    frase = Console.ReadLine();
                }
            }

            StreamReader ficheroR = new StreamReader("registroDeUsuario.txt");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ficheroR.ReadLine());
            }

            ficheroR.Close();
        }
    }
}
