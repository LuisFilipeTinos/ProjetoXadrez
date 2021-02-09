﻿using System;
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

        public void IncrementoDeQtdMovimentos()
        {
            QtdDeMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
        
    }
}
