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

            Console.Write("Média Zuqui " + CalcularMedia(xNotasZuqui));
            if (CalcularMedia(xNotasZuqui) > 7.00)
            {
                    Console.WriteLine(" Passou no ano letivo!");
            } else
            {
                Console.WriteLine(" Não passou no ano letivo!");
            }

            Console.Write("Média Bronza " + CalcularMedia(xNotasBronza));
            if (CalcularMedia(xNotasBronza) > 7.00)
            {
                    Console.WriteLine(" Passou no ano letivo!");
            }else
            {
                Console.WriteLine(" Não passou no ano letivo!");
            }

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