using System;

class Ex01
{
    public static void Executar()
    {
        const int linhas = 3;
        const int colunas = 3;
        int l = 0;
        int c = 0;

        char[,] matriz = new char[linhas, colunas];

        for (l = 0; l < linhas; l++)
        {
            for (c = 0; c < colunas; c++)
            {
                matriz[l, c] = char.Parse(Console.ReadLine());
            }
        }

        for (l = linhas - 1; l >= 0; l--)
        {
            for (c = colunas - 1; c >= 0; c--)
            {
                Console.WriteLine(matriz[l, c]);
            }
            Console.WriteLine();
        }

    }
}