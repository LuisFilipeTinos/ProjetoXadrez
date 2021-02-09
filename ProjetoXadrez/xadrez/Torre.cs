using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
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

            //acima
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.Linha = pos.Linha - 1;
            }


            //abaixo
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.Linha = pos.Linha + 1;
            }


            //direita
            pos.DefinirValores(PosicaoPeca.Linha, PosicaoPeca.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.Coluna = pos.Coluna + 1;
            }


            //esquerda
            pos.DefinirValores(PosicaoPeca.Linha, PosicaoPeca.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab._peca(pos) != null && Tab._peca(pos).CorPeca != this.CorPeca)
                {
                    break;
                }

                pos.Coluna = pos.Coluna - 1;
            }


            return mat;
        }
    }
}
