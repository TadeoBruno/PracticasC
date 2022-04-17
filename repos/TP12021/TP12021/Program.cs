using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP12021
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int[] vecval = Enumerable.Repeat(0, 5).ToArray();
            int cat, leg, hs, i, sdo, tot;
            tot = 0;
            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine("Ingrese el valor de la horas de la categoria {0}", i);
                cadena = Console.ReadLine();
                vecval[i] = Convert.ToInt32(cadena);
            }
            Console.WriteLine("Ingrese el numero de legajo");
            cadena = Console.ReadLine();
            leg = Convert.ToInt32(cadena);
            while (leg != 0)
            {
                Console.WriteLine("Ingrese el numero de categoria");
                cadena = Console.ReadLine();
                cat = Convert.ToInt32(cadena);
                Console.WriteLine("Ingrese el numero de horas trabajadas");
                cadena = Console.ReadLine();
                hs = Convert.ToInt32(cadena);
                sdo = hs * vecval[cat];
                Console.WriteLine("El legajo {0} cobrara {1}\n", leg, sdo);
                tot = tot + sdo;
                Console.WriteLine("Ingrese el numero de legajo");
                cadena = Console.ReadLine();
                leg = Convert.ToInt32(cadena);
            }
            Console.WriteLine("El total a pagar por sueldos es {0}", tot);
            Console.ReadKey();
        }
    }
}
