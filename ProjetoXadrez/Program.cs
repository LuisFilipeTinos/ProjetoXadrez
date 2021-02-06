using System;
using tabuleiro;
using xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 5);
            
            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();

        }
    }
}
