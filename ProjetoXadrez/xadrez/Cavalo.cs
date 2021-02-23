using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }


        public override string ToString()
        {
            return "C";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab._peca(pos);
            if (p == null || this.CorPeca != p.CorPeca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima e direita
            pos.DefinirValores(PosicaoPeca.Linha - 2, PosicaoPeca.Coluna + 1);
            if(Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //acima e esquerda
            pos.DefinirValores(PosicaoPeca.Linha - 2, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //frente e acima
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 2);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //frente e abaixo
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 2);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //trás e cima
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna - 2);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //trás e baixo
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 2);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo e direita
            pos.DefinirValores(PosicaoPeca.Linha + 2, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo e esquerda
            pos.DefinirValores(PosicaoPeca.Linha + 2, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }


    }
}
