using System;

class Prgram
{
    static void Main(string [] args)
    {
        const string usuario = "admin";
        const string senha = "123senha";
        const int numberoDeTentativas = 3;
        int i = 1;

        do
        {
            Console.WriteLine("Digite o nome de usuario:");
            string usuarioDigitado = Console.ReadLine();
            
            Console.WriteLine("Digite a senha:");
            string senhaDigitada = Console.ReadLine();

            if( usuario == usuarioDigitado && senha == senhaDigitada )
            {
                Console.WriteLine("Login realizado com sucesso!");
                break;
            }
            else
            {
                Console.WriteLine("\nCredenciais inválidas!");
                Console.WriteLine("Voce tem " + (numberoDeTentativas - i) + " tentativa(s).\n\n");
                i++;
            }            

        }
        while( i <= numberoDeTentativas);
        
        if (i > numberoDeTentativas)
        {
            Console.WriteLine("Sua conta foi bloqueada!");
        }
    }
}