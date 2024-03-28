using System;

class Program
{
    static void Main(string[] args)

    {
        const int matrizTamanho = 3;
        int[,] matriz = new int[matrizTamanho, matrizTamanho];
        int soma = 0;

        for (int i = 0; i < matrizTamanho; i++)
        {
            for (int j = 0; j < matrizTamanho; j++)
            {

                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < matrizTamanho; i++)
        {
            for (int j = 0; j < matrizTamanho; j++)
            {
                if(i == j)
                {
                    soma += matriz[i, j];
                }
                
            }
        }

        Console.WriteLine(soma);
    }
}