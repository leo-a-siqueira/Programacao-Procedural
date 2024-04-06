using System;

class Program
{
    public static void Main(string[] args)
    {
        const int tamanhoMatriz = 4;
        int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];

        matriz = PreencherMatriz(tamanhoMatriz);
        bool validador = VerificarBalistas(matriz);

        if (validador == true)
        {
            Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
        else
        {
            Console.WriteLine("nao ha balistas no tabuleiro");
        }
    }

    static int[,] PreencherMatriz(int tamanhoMatriz)
    {
        int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];

        for (int i = 0; i < tamanhoMatriz; i++)
        {
            for (int j = 0; j < tamanhoMatriz; j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return matriz;
    }

    static bool VerificarBalistas(int[,] matriz)

    {
        const int tamanhoMatriz = 4;

        bool validador = false;

        for (int i = 0; i < tamanhoMatriz; i++)
        {
            for (int j = 0; j < tamanhoMatriz; j++)
            {
                if (matriz[i, j] == 0)
                {
                    validador = true;
                }
            }
        }
        return validador;
    }
}