using System;

namespace CalculadoraSimples
{
    class Calculadora
    {
        static void Main(string[] args)
        {

            bool sair = false; // Armazendo um valor falso

            // é usada para uma execução iterativa (loop) enquanto uma condição de teste especificada é verdadeira.
            while (!sair) // https://www.youtube.com/watch?v=P5OiZFmG8bc

            // Grava os dados especificados, seguidos pelo terminador de linha atual, no fluxo de saída padrão.
            Console.WriteLine("===Calculadora Simples===")
            Console.WriteLine("===Selecione uma operação:===")
            Console.WriteLine("1. Adição")
            Console.WriteLine("2. Subtração")
            Console.WriteLine("3. Multiplicação")
            Console.WriteLine("4. Divisão")
            Console.WriteLine("5. Sair")

            Console.Write("Opção: ");
            int opcao = int.Parse(console.ReadLine());

            if (opcao == 5)
            {
                sair = true;
                Console.WriteLine("Saindo...")
                break;
            }
        }
    }
}