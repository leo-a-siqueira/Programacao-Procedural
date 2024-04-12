using System;

struct pizza
{
    public int id;
    public string sabor;
    public double preco;


}
class Program
{
    static void Main(string[] args)
    {
        pizza pizza1;
        pizza1.id = Convert.ToInt32(Console.ReadLine());
        pizza1.sabor = Console.ReadLine();
        pizza1.preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(pizza1.id + "\n" + pizza1.sabor + "\n" + pizza1.preco);
    }
}