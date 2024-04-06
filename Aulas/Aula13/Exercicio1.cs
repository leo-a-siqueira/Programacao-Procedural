using System;

struct Jogo
{
    public int id;
    public string name;
    public double price;
}
public class Exercicio1
{
    public static void Exercicio01(string[] args)
    {
        Jogo jogo1;
        jogo1.id = Convert.ToInt32(Console.ReadLine());
        jogo1.name = Console.ReadLine();
        jogo1.price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(jogo1.id + "\n" + jogo1.name + "\n" + jogo1.price);
    }
}