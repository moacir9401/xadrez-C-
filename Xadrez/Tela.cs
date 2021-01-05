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
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    ImprimirPeca(tab.peca(i, j));

                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());
            return new PosicaoXadrez(coluna, linha);
        }

        internal static void imrpimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;

                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;
        }

        public static void ImprimirPeca(Peca peca)
        {

            ConsoleColor aux = Console.ForegroundColor;
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {

                switch (peca.cor)
                {
                    case Cor.Branca:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Cor.Preta:
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case Cor.Amarela:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Cor.Azul:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Cor.Vermelha:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Cor.Verde:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Cor.Laranja:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    default:
                        break;
                }



                Console.Write(peca);
                Console.Write(" ");
            }
            Console.ForegroundColor = aux;
        }

    }
}
