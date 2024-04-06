using System;

struct Enxadrista
{
    public int id;
    public string nome;
    public int rating;
}
class Exercicio2
{
    public static void Main(string[] args)
    {
        const int tamanhoEnxadrista = 4;
        Enxadrista[] enxadristas = new Enxadrista[tamanhoEnxadrista];

        for (int i = 0; i < enxadristas.Length; i++)
        {
            enxadristas[i].id = Convert.ToInt32(Console.ReadLine());
            enxadristas[i].nome = Console.ReadLine();
            enxadristas[i].rating = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = enxadristas.Length -1; i >= 0; i--)
        {
            Console.WriteLine(enxadristas[i].id);
            Console.WriteLine(enxadristas[i].nome);
            Console.WriteLine(enxadristas[i].rating);
        }
    }
}