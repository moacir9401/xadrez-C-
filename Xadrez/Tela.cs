using System;
using tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void imrpimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                        continue;
                    }
                    Console.Write($"{tab.peca(i, j)} ");
                }
                Console.WriteLine();
            }
        }

    }
}
