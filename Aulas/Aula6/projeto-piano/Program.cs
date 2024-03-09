class Program 
{
    static void Main(string[] args)
    {
        int contador = 1;
        const int finalNota = 7;


        while (contador <= finalNota)
        {
            Piano.ReproduzTecla(2, contador);
            contador++;
        }
        Piano.ReproduzTecla(3,1);

      

        
    }
}