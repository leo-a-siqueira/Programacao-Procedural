using System;

class Ex02
{
    public static void Executar()
    {
        const int linha = 4;
        const int coluna = 4;
        int[,] matriz = new int[linha, coluna];
        int soma = 0;

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                soma += matriz[i, j];
            }
        }
        Console.WriteLine("A soma de todos os elementos da matriz eh: " + soma);


    }
}