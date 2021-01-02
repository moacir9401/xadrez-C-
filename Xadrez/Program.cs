﻿using System;
using tabuleiro;
using Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                //tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                //Tela.imrpimirTabuleiro(tab);


                var pos = new PosicaoXadrez('c',7);
                Console.WriteLine(pos.toPosicao());
            }
            catch (TabuleiroExceptions e)
            {

                 Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
