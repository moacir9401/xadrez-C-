using System;
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
                var partida = new PartidaDeXadrez();

                Tela.imrpimirTabuleiro(partida.tab);

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imrpimirTabuleiro(partida.tab);
                    Console.Write("Digite a posicao de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.imrpimirTabuleiro(partida.tab, posicoesPossiveis);

                    Console.Write("Digite a posicao de destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }
            }
            catch (TabuleiroExceptions e)
            {

                 Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
