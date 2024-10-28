// https://www.youtube.com/watch?v=HeMvWAStj2M&list=PLY-9oEzuBhdfzxLxLeTr56YG8Vqu-Y0dl&index=2 

class Program
{
    static void Main(String[] args)
    {
        // Como declaramos uma variavel no csharp?
        // Existem três maneiras

        // Mais usadas e mais segura de todas:
        // INT - Armazena números inteiros.
        // Float - Armazena números flutuantes => Números decimais.
        // Bool - Só pode ter dois valores (Verdadeiro (True) ou Falso (False)).
        // String - Tipo de dado que é Identificado quando tem aspas duplas. Estilo Texto.
        // Char - Character, identificado com aspas simples.

        // Nomes de variaveis: Proibido ter = > Espaços, Simbolos, Sinais, E o nome da Variavel não pode começar com Número.

        int segundaGuerraMundial = 1942; // Valor inteiro = > A partir do momento em que eu defino o tipo da variavel, ela só pode armazenar aquele tipo de dado.
        float segundaGuerraFloat = 1942,1; // Valor flutuante
        bool segundaGuerraIsTrue = true; // Valor verdadeiro
        string segundaGuerraTxt = "Segunda Guerra Mundial"; // Texto


        Console.WriteLine(segundaGuerraMundial); // 
        Console.WriteLine(segundaGuerraFloat);
        Console.WriteLine(segundaGuerraIsTrue);
        Console.WriteLine(segundaGuerraTxt);
        Console.ReadLine();
    }
}