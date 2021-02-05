using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace ProjetoXadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if(tab._peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab._peca(i, j) + " ");
                    }
                }
                
                Console.WriteLine();
            }
           
        }


    }


}
