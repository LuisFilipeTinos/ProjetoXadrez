using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "P";
        }

        public bool ExisteInimigo(Posicao pos)
        {
            Peca p = Tab._peca(pos);
            if(p != null && p.CorPeca != this.CorPeca)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public bool Livre(Posicao pos)
        {
            if(Tab._peca(pos) == null)
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

            if(this.CorPeca == Cor.Branca)
            {
                pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna);
                if(Tab.PosicaoValida(pos) == true && Livre(pos) == true)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(PosicaoPeca.Linha - 2, PosicaoPeca.Coluna);
                if(Tab.PosicaoValida(pos) == true && Livre(pos) == true && QtdDeMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna - 1);
                if (Tab.PosicaoValida(pos) == true  && ExisteInimigo(pos) == true)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(PosicaoPeca.Linha - 1, PosicaoPeca.Coluna + 1);
                if (Tab.PosicaoValida(pos) == true  && ExisteInimigo(pos) == true)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {
                pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna);
                if (Tab.PosicaoValida(pos) == true && Livre(pos) == true)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(PosicaoPeca.Linha + 2, PosicaoPeca.Coluna);
                if (Tab.PosicaoValida(pos) == true && Livre(pos) == true && QtdDeMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna - 1);
                if (Tab.PosicaoValida(pos) == true  && ExisteInimigo(pos) == true)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(PosicaoPeca.Linha + 1, PosicaoPeca.Coluna + 1);
                if (Tab.PosicaoValida(pos) == true  && ExisteInimigo(pos) == true)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;
        
        }
    }
}
