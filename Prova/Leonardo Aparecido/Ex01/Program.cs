class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());

        double resultado = peso / (altura * altura);

        Console.WriteLine("O IMC eh igual a: " + Math.Round(resultado, 2));

    }
}