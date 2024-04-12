using System;
using System.Diagnostics.Contracts;

class Program
{

    static void Viajar()
    {
        int pais = Convert.ToInt32(Console.ReadLine());

        if (pais == 1)
        {
            VisitarPaisDoFogo();
        }
        else if (pais == 2)
        {
            VisitarPaisDoVento();
        }
    }

    static void VisitarPaisDoFogo()
    {
        int explorar = Convert.ToInt32(Console.ReadLine());

        if (explorar == 1)
        {
            Console.WriteLine("Voce adentrou: Aldeia da folha");
        }
        else if (explorar == 2)
        {
            Console.WriteLine("Voce adentrou: Floresta da morte");
        }
    }
    static void VisitarPaisDoVento()
    {
        int explorar = Convert.ToInt32(Console.ReadLine());

        if (explorar == 1)
        {
            Console.WriteLine("Voce adentrou: Aldeia da areia");
        }
        else if (explorar == 2)
        {
            Console.WriteLine("Voce adentrou: Mina");
        }
        else if (explorar == 3)
        {
            Console.WriteLine("Voce adentrou: Caatinga");
        }
    }

    static void Main(string[] args)
    {

        Viajar();
    }
}