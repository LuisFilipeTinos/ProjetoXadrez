using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "B";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab._peca(pos);
            return p == null || p.CorPeca != this.CorPeca;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            //direita superior
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 1);
            while (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {               
                mat[pos.Linha, pos.Coluna] = true;

                if(Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }

            //esquerda inferior
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna - 1);
            while (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //direita inferior
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 1);
            while (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //esquerda superior
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 1);
            while (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }
                
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return mat;
        
        
        }


    }
}
