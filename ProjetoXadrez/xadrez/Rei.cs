using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {

        private PartidaDeXadrez partida;
        public Rei(Cor cor, Tabuleiro tab, PartidaDeXadrez partidaDeXadrez) : base(cor, tab)
        {
            this.partida = partidaDeXadrez;
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab._peca(pos);
            return p == null || p.CorPeca != this.CorPeca;
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tab._peca(pos);
            if(p != null && p is Torre && p.CorPeca == this.CorPeca && p.QtdDeMovimentos == 0)
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

            //acima
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
            if(Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //nordeste
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.DefinirValores(PosicaoPeca.Linha, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.DefinirValores(PosicaoPeca.Linha, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna - 1);
            if (Tab.PosicaoValida(pos) == true && PodeMover(pos) == true)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //#jogadaespecial roque 

            if(this.QtdDeMovimentos == 0 && !partida.Xeque)
            {
                //#jogadaespecial roque pequeno
                Posicao posT1 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 3);
                if (TesteTorreParaRoque(posT1) == true)
                {
                    Posicao p1 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 1);
                    Posicao p2 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna + 2);
                    if(Tab._peca(p1) == null && Tab._peca(p2) == null)
                    {
                        mat[PosicaoPeca.Linha, PosicaoPeca.Coluna + 2] = true; 
                    }
                }
            }

            if (this.QtdDeMovimentos == 0 && !partida.Xeque)
            {
                //#jogadaespecial roque grande
                Posicao posT2 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 4);
                if (TesteTorreParaRoque(posT2) == true)
                {
                    Posicao p1 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 1);
                    Posicao p2 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 2);
                    Posicao p3 = new Posicao(PosicaoPeca.Linha, PosicaoPeca.Coluna - 3);
                    if (Tab._peca(p1) == null && Tab._peca(p2) == null && Tab._peca(p3) == null)
                    {
                        mat[PosicaoPeca.Linha, PosicaoPeca.Coluna - 2] = true;
                    }
                }
            }

            return mat;
        }
    }
}
