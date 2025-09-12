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
            ejer4();
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
            Console.Write("Ingrese un número decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num, 0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1.0 / 3.0);

            Console.WriteLine("\nLa raíz cuadrada es: " + raiz2);
            Console.WriteLine("El valor redondeado sin decimales es: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raíz 3: " + raiz3);
        }
        static void ejer5()
        {
            Console.Write("Ingrese un número: ");
            string num=Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.Write("Resto: "+(entero%2));
            Console.Write("Divi 3: " + deci / 3);
        }
        
    }
}
