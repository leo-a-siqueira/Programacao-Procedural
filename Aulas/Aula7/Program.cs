using System;

class Program
{
    static void Main(string[] args)
    {
        /* ///soma do numeros imparares
        int somatorio = 0;
        int valorUser = 0;

        while(somatorio <= 50)
        
        {
            System.Console.WriteLine("Digite o valor: ");
            valorUser = int.Parse(Console.ReadLine());

            if (valorUser % 2 != 0)
            {
                somatorio = somatorio + valorUser;                
            }         

        }      

        System.Console.WriteLine("Valor somado eh:" + somatorio);
        */

        ///Fazedor de tabuadas até 10
        System.Console.WriteLine("Digite o numero da tabuada:");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());
        
        if(numeroDigitado == 0 )
        {
            System.Console.WriteLine("Todo valor x 0 eh 0. Nao precisa de tabuada.");
        }

        else
        {

            System.Console.WriteLine("\nTabuada do " + numeroDigitado + " abaixo:");

                for(int i= 1 ; i <= 10 && numeroDigitado != 0 ; i++)
                {
                    int resultado = (i* numeroDigitado);
                    Console.WriteLine(" " + numeroDigitado + " X " + i + " = " + resultado);
                }
        }
        
    }

}