using System;

class Program
{
    static void Main(string[] args)
    {
        const int tamanhoVetor = 10;
        const int numeroMinimo = 10;
        const int numeroMaximo = 50;

        int[] vetor = new int[tamanhoVetor];
        

        for (int i = 0; i < tamanhoVetor; i++)
        {
            int numeroDigitado = 0;
            do
            {
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                vetor[i] = numeroDigitado;
            }
            while (numeroDigitado < numeroMinimo || numeroDigitado > numeroMaximo);
        }

        for (int i = 0; i < tamanhoVetor ; i++)
        {
            Console.WriteLine(vetor[i]);
        }
    }
}