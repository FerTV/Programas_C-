﻿using System;
using System.IO;

namespace Ejercicio_8_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            StreamReader ficheroR;

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

            ficheroR = File.OpenText("registroDeUsuario.txt");
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(ficheroR.ReadLine());
            }
            ficheroR.Close();
        }
    }
}
