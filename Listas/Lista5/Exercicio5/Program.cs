using System;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro.InicializaTabuleiro();

        for (int linha = 0; linha <= 7; linha++)
        {
            if (linha % 2 == 0)
            {
                for (int coluna = 0; coluna <= 7; coluna++)
                {
                    Tabuleiro.Adicionar(linha, coluna, "C");
                }
            }
        }

        Tabuleiro.ImprimeTabuleiro();
    }
}