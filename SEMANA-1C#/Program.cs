using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey();
        }
        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Coloque su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Coloque su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso de FA de la carrera {carrera}");
        }
        static void ejer2()
        {
            Console.WriteLine("\"Gianfranco\"");
        }
        static void ejer3()
        {
            int n1, n2;
            

            Console.Write("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            double división =(double) n1 / (double)n2;

            Console.WriteLine($"\nLa suma es: {n1+n2}");
            Console.WriteLine($"La resta es: {n1-n2}");
            Console.WriteLine($"La multiplicación es: {n1*n2}");
            Console.WriteLine($"La división es: {división}");
        }
        static void ejer4()
        {
            double n1, raiz_c;

            Console.Write("Ingrese un numero decimal: ");
            n1=double.Parse(Console.ReadLine());

            raiz_c = Math.Pow(n1, 0.5);

        }
    }
}
