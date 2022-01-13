using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] tabuleiro = new char[3, 3];
            tabuleiro[0, 0] = 'X';
            tabuleiro[1, 0] = '.';
            tabuleiro[2, 0] = 'O';
            tabuleiro[0, 1] = 'X';
            tabuleiro[1, 1] = 'X';
            tabuleiro[2, 1] = 'O';
            tabuleiro[0, 2] = '.';
            tabuleiro[1, 2] = 'O';
            tabuleiro[2, 2] = 'X';

            for (var y = 0; y <= tabuleiro.GetUpperBound(1); y++)
            {
                for (var x = 0; x <= tabuleiro.GetUpperBound(0); x++)
                {
                    Console.Write(tabuleiro[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
