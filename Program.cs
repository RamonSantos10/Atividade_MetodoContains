using System;
using static System.Console;

namespace MetodoContains
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo_Contains1();
            WriteLine("-----------------");
            Metodo_Contains2();
            
        }

        private static void Metodo_Contains1()
        {
            string nomes = "Ramon, Pedro, Bruno, Antonio, Victor";
            bool listaNomes = nomes.Contains('y');

            WriteLine(listaNomes);
        }

        private static void Metodo_Contains2()
        {
            string nomes = "Ramon, Pedro, Bruno, Antonio, Victor";
            bool listaNomes = nomes.Contains(',');

            WriteLine(listaNomes);
        }
    }
}
