using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite o numero exercicio para executar:");


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i + 1) + " => Exercicio " + (i + 1));
            }
            System.Console.Write("\nResposta:");

            int seletor = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("______________________________________________________________________________________________________\n");
            
            if (seletor == 1)
            {
                Ex01.Executar();
            }

            else if (seletor == 2)
            {
                Ex02.Executar();
            }

            else if (seletor == 3)
            {
                Ex03.Executar();
            }

            else if (seletor == 4)
            {
                Ex04.Executar();
            }

        }


    }
}
