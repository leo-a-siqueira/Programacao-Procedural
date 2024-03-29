using System;

class Program
{
    static void Main(string[] args)
    {
        const int tamanhoMatriz = 3;
        int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];
        int diagonal = tamanhoMatriz -1;

        for (int i = 0; i < tamanhoMatriz; i++)
        {
            for (int j = 0; j < tamanhoMatriz; j++)
            {
                if (j == diagonal)
                {
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine()) * 2;
                    diagonal--;
                }
                else
                {
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        for (int i = 0; i < tamanhoMatriz; i++)
        {
            for (int j = 0; j < tamanhoMatriz; j++)
            {
                Console.Write(matriz[i, j] + "|");
            }
            Console.WriteLine();
        }
    }
}