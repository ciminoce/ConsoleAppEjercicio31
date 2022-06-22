using System;

namespace ConsoleAppEjercicio31b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando Bisiestos...");
            Console.Write("Ingrese un año calendario:");
            var anio = int.Parse(Console.ReadLine());
            if (VerficarBisiesto(anio))
            {
                Console.WriteLine($"{anio} es bisiesto");
                
            }
            else
            {
                Console.WriteLine($"{anio} no es bisiesto");
                
            }

            Console.ReadLine();

        }

        private static bool VerficarBisiesto(int anio)
        {
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
