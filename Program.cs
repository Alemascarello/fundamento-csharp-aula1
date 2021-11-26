using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnetcore
{
    class Program
    {

        static void Main(string[] args)
        {
            var xPessoas = new List<Pessoas>();

            xPessoas.Add(new Pessoas(10, "Paulinho"));
            xPessoas.Add(new Pessoas(21, "Fulano"));
            xPessoas.Add(new Pessoas(18, "Ciclano"));
            xPessoas.Add(new Pessoas(40, "Beltrano"));

            // for (int i = 0; i < 4; i++)
            // {

            //     Console.WriteLine("Digite o Nome ");
            //     string nome = Console.ReadLine();

            //     Console.WriteLine("Digite a Idade: ");
            //     int idade = int.Parse(Console.ReadLine());

            //     xPessoas.Add(new Pessoas(idade, nome));
            // }

            var xMediaIdade = xPessoas.Average(p => p.Idade);
            var xMaisVelho = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault().Nome;
            var xMaiorIdade = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault().Idade;
            var xMaisNovo = xPessoas.OrderByDescending(p => p.Idade).LastOrDefault().Nome;
            var xMenorIdade = xPessoas.OrderByDescending(p => p.Idade).LastOrDefault().Idade;
            var xAdultos = xPessoas.Where(p => p.Idade >= 18).Count();

            Console.WriteLine($"A média da idade das pessoas é: {xMediaIdade.ToString("F2")}");
            Console.WriteLine($"A pessoa mais velha é {xMaisVelho} e ela tem {xMaiorIdade} anos.");
            Console.WriteLine($"A pessoa mais nova é {xMaisNovo} Ela tem {xMenorIdade} anos.");
            Console.WriteLine($"A quantidade de pessoas com mais de 18 anos é: {xAdultos}");






        }
    }

}