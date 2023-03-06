using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_TestaCondicional2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Exercício 6 - Teste de Condicional - If");

            int idade = 18;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar.");
            }
            Console.ReadLine();
        }
    }
}
