using System;

class Program
{
    struct Produto
    {
        public int id;
        public string nome;
        public double preco;
        public bool disponivelEmEstoque;
    }

    static void Main(string[] args)
    {
        const int tamanhoVetor = 4;
        Produto[] produtos = new Produto[tamanhoVetor];

        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i].id = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponivelEmEstoque = Convert.ToBoolean(Console.ReadLine());
        }

        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].disponivelEmEstoque == true)
            {
                Console.WriteLine(produtos[i].nome);
                Console.WriteLine(produtos[i].preco.ToString("F"));
            }
        }

    }
}