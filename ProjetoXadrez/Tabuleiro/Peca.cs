using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {

        public Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QtdDeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor corPeca, Tabuleiro tab)
        {
            this.PosicaoPeca = null;
            this.CorPeca = corPeca;
            this.Tab = tab;
            this.QtdDeMovimentos = 0;
        }

        public bool ExistemMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i,j] == true)
                    {
                        return true;
                    }
                    
                    
                }

               
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna] == true;
        }
        public void IncrementoDeQtdMovimentos()
        {
            QtdDeMovimentos++;
        }

        public void DecrescerQtdMovimentos()
        {
            QtdDeMovimentos--;
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
