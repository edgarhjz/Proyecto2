using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class Program
    {
        static void Sumar()
        {
            Console.Write("Ingrese el primer número: ");
            int sumando1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int sumando2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es = {(sumando1 + sumando2)}");
        }
        static void Restar()
        {
            Console.Write("Ingrese el primer número: ");
            int minuendo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int sustraendo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es = {(minuendo - sustraendo)}");
        }
        static void Multiplicar()
        {
            Console.Write("Ingrese el primer número: ");
            int multiplicando = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int multiplicador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es = {(multiplicando * multiplicador)}");
        }
        static void Dividir()
        {
            Console.Write("Ingrese el primer número: ");
            int dividendo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El resultado de la suma es = {(dividendo / divisor)}");
        }
        static void Calculadora()
        {
            bool fin = false;
            int opcion = 0;

            while(!fin)
            {
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        fin = true;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            // Your Code
        }
    }
}
