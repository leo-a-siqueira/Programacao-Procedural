using System;

class Ex03
{
    public static void Executar()
    {
        const int linha = 8;
        const int coluna = 8;
        int[,] matriz = new int[linha, coluna];

        for (int i = 0; i < linha; i++)
        {
            for (int i2 = 0; i2 < coluna; i2++)
            {
                if (i - i2 == 0)
                {
                    matriz[i, i2] = Convert.ToInt32("1");
                }

            }
        }

        for (int i = 0; i < linha; i++)
        {
            for (int i2 = 0; i2 < coluna; i2++)
            {
                Console.Write(matriz[i, i2]);
            }
            Console.WriteLine();
        }


    }
}
