using System;

class Program
{
    static void Main(string[] args)
    {
        /** EXERCICIO 1 **/
        /**
        int i2 = 50;
        for (int i = 0; i <= 50; i++)
        {
            Console.WriteLine(i + " - " + i2);
            i2--;
        **/

        /** EXERCICIO 2 **/
        /**
        int numerosPositivos = 0;
        int numerosNegativos = 0;
        int numerosZero = 0;

        for (int i = 1 ; i <= 10 ; i++)
        {
            Console.WriteLine("Digite o " + i + "° numero:");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if( numeroDigitado > 0 )
            {
                numerosPositivos++;
            }
            else if(numeroDigitado < 0)
            {
                numerosNegativos++;
            }
            else
            {
                numerosZero++;
            }            

        }
        Console.WriteLine("\nNumeros positivos: " + numerosPositivos);
        Console.WriteLine("Numeros negativos: " + numerosNegativos);
        Console.WriteLine("Zero(s): " + numerosZero);**/

        /** EXERCICIO 3 **/
        /**
        int somatorio = 0;
        Console.WriteLine("Digite um numero:");
        int numeroDigitado = int.Parse(Console.ReadLine());

        if (numeroDigitado > 0)
        {
            for (int i = 0; i <= numeroDigitado; i++)
            {
                if (i % 2 != 0)
                {
                    somatorio = somatorio + i;
                }
            }

            Console.WriteLine("O somatorio de todos numeros impares eh: " + somatorio);
        }
        else if (numeroDigitado < 0)
        {
            for (int i = 0; numeroDigitado <= i ; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }            
        }
        else
        {
            Console.WriteLine("nada a fazer aqui");
        }
        **/

        /** EXERCICIO 4 **/

        /**
        for(int i = 120 ; i >= 0 ; i--)
        {
            int minutos = i / 60;
            int segundos = i % 60;

            Console.WriteLine($"{minutos} : {segundos}");
        }
        **/

        /** EXERCICIO 5 **/
Tabuleiro.InicializaTabuleiro();
    
    for(int i = 0 ; i <= 7; i++)
    {
      if(i%2 != 0)
      {
        for(int i2 = 0; i2 <= 7; i2 ++)
        {
          if(i2 % 2 != 0)
          {
            Tabuleiro.Adicionar(i,i2, "B");            
          }
        }
      }
      
    }
    
    
    Tabuleiro.ImprimeTabuleiro();
    
  }
}

class Tabuleiro
{
    const int TAMANHO_TABULEIRO = 8;
    private static string[,] tabuleiro = new string[TAMANHO_TABULEIRO,TAMANHO_TABULEIRO];
    public static void Adicionar(int coordenadaX, int coordenadaY, string dado)
    {
        if ((coordenadaX < 0 || coordenadaX >= TAMANHO_TABULEIRO)
            || (coordenadaY < 0 || coordenadaY >= TAMANHO_TABULEIRO))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("você só pode inserir coordenadas entre 0 e 7");
            Console.ResetColor();
            Environment.Exit(0);
        } 

        tabuleiro[coordenadaX, coordenadaY] = dado;
    }

    public static void ImprimeTabuleiro()
    {
        System.Console.WriteLine("    0   1   2   3   4   5   6   7");
        System.Console.WriteLine("  ---------------------------------");
        for (int linha = 0; linha < TAMANHO_TABULEIRO; linha++)
        {
            System.Console.Write(linha + " ");
            for (int coluna = 0; coluna < TAMANHO_TABULEIRO; coluna++)
            {
                System.Console.Write($"| {tabuleiro[linha, coluna]} ");
                Thread.Sleep(50);
            }
            
            System.Console.WriteLine("|");
            System.Console.Write("  ---------------------------------");
            System.Console.WriteLine();
            
        }
    }

    public static void InicializaTabuleiro()
    {
        for (int linha = 0; linha < TAMANHO_TABULEIRO; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_TABULEIRO; coluna++)
            {
                tabuleiro[linha, coluna] = " ";
            }
        }
        
    }
}