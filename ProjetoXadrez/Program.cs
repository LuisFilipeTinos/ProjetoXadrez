using System;
using tabuleiro;
using xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 5));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(5, 6));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(1, 7));

                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(4, 4));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine( e.Message);
            }
            Console.ReadLine();

        }
    }
}
