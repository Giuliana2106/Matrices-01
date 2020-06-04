using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz
{
    class Program
    {
        static string i = "Isa";
        static string c = "Edy";
        static string[] nombres = new string[n, n];

       static void Main(string[]args)
        {

            for (int i = 0; i < 3; i++) ;
            {
                for (int c = 0; c < 3; c++) ;
                {
                    Console.WriteLine("i: " + i + " c: " + c + "\n\n");
                    Console.Write("Ingrese nombres: ");
                    linea = Console.ReadLine();
                    nombres[i, c] = string.Parse(linea);
                }
            }
            for (int i = 0; i < 3; i++) ;
            {
                for (int c = 0; c < 3; c++) ;
                {
                    Console.WriteLine("Nombres: " + nombres[i, c]);

                }
            }

            Console.ReadKey();
        }
    }
}
