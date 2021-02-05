using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {

        public Posicao PosicaoPeca { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QtdDeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicaoPeca, Cor corPeca, Tabuleiro tab)
        {
            this.PosicaoPeca = posicaoPeca;
            this.CorPeca = corPeca;
            this.Tab = tab;
            this.QtdDeMovimentos = 0;
        }
    }
}
