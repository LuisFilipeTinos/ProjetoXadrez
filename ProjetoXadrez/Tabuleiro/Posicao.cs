using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Posicao
    {
        public int Linha { get; private set; }
        public int Coluna { get; private set; }


        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
