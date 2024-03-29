using System;
class Program
{
    static void Main(string[] args)
    {
        const int tamanhoMatriz = 4;
        int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];

        for (int i = 0; i < tamanhoMatriz; i++)
        {
            for (int j = 0; j < tamanhoMatriz; j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }
        }
        else if (opcao == 2)
        {
            int soma = 0;
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    soma += matriz[i, j];
                }
            }

            Console.WriteLine(soma);
        }

        else if (opcao == 3)
        {
            int soma = 0;
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                soma += matriz[2, i];
            }
            Console.WriteLine(soma);
        }

        else if (opcao == 4)
        {
            int soma = 0;
            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    if (i == j)
                    {
                        soma += matriz[i, j];
                    }
                }
            }
            Console.WriteLine(soma);
        }

        else if( opcao == 5)
        {
            int soma = 0;
            for (int i = 0 ; i < tamanhoMatriz ; i++)
            {
                if(matriz [i, 1] % 2 == 0)
                {
                    soma += matriz[i, 1];
                }
            }
            Console.WriteLine(soma);
        }
    }
}