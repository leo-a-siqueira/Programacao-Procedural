using System;
class Program
{
    static void Main(string[] args)
    {
        const int tamanhoTrem = 12;
        int[] vagoes = new int[tamanhoTrem];

        vagoes = PreencherTrem(tamanhoTrem);

        VerificarPeso(vagoes);
    }
    static int[] PreencherTrem(int tamanhoTrem)
    {
        int[] vagoes = new int[tamanhoTrem];
        for (int i = 0; i < vagoes.Length; i++)
        {
            vagoes[i] = Convert.ToInt32(Console.ReadLine());
        }

        return vagoes;
    }

    static void VerificarPeso(int[] vagoes)
    {
        const int pesoMaximo = 50;
        for (int i = 0; i < vagoes.Length; i++)
        {
            if (vagoes[i] > pesoMaximo)
            {
                Console.WriteLine((i + 1) + "° vagao ultrapassou o limite de peso");
                
            }
        }
    }
}