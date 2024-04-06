using System;
class Program
{
    static void Main(string[] args)
    {
        int[] num = lerNumeros();
        imprimirMaiorNumero(num);
    }
    static int[] lerNumeros()
    {
        const int tamanhoVetor = 3;
        int[] numeros = new int[tamanhoVetor];

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }
        return numeros;
    }

    static void imprimirMaiorNumero(int[] numeros)
    {
        int numeroMaior = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeroMaior < numeros[i])
            {
                numeroMaior = numeros[i];
            }
        }
        Console.WriteLine(numeroMaior); ;
    }
}