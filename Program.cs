using System;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {

        static void Main(string[] args)
        {
            var xNotasZuqui = new List<float> { 7, 6, 5, 3 };
            var xNotasBronza = new List<float> { 8, 9, 10, 8 };

            Console.WriteLine("Média Zuqui " + CalcularMedia(xNotasZuqui));

            Console.WriteLine("Média Bronza " + CalcularMedia(xNotasBronza));
            
        }

        public static float CalcularMedia(List<float> Notas)
        {

            float media = 0;

            for (int i = 0; i < Notas.Count; i++)
            {
                media = media + Notas[i];
            }
            return media / Notas.Count;

        }

    }
}