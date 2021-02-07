using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca _peca(int linha, int coluna)
        {
            return pecas[linha, coluna];


        }

        public Peca _peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return _peca(pos) != null;
            
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Ja existe uma peca nessa posicao!");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.PosicaoPeca = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if(_peca(pos) == null)
            {
                return null;

            }
            else
            {
                Peca aux = _peca(pos);
                aux.PosicaoPeca = null;
                pecas[pos.Linha, pos.Coluna] = null;
                return aux;
            }
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void ValidarPosicao(Posicao pos)
        {
            if(PosicaoValida(pos) == false)
            {
                throw new TabuleiroException("Posicao invalida!");
            }
           
        }

    }
}
