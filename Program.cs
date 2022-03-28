using System;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hola Mundo");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("El conflicto 3 debería solucionarse solo.");
            Console.ResetColor();
        }
    }
}
