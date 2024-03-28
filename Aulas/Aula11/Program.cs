using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nomes = new string[5];
            int[] idades = new int[5];
            bool[] ehCasado = new bool[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                nomes[i] = Console.ReadLine();
                idades[i] = Convert.ToInt32(Console.ReadLine());
                ehCasado[i] = Convert.ToBoolean(Console.ReadLine());
            }

            Console.WriteLine("As pessoas casadas sao:");

            for (int i = 0; i < nomes.Length; i++)
            {
                if (ehCasado[i] == true)
                {
                    Console.WriteLine(nomes[i] + ", de " + idades[i] + " anos");
                }
            }


        }
    }
}