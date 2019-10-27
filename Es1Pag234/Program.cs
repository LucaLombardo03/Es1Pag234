using System;

namespace Es1Pag234
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeri = 0;
            int somma = 0;
            Leggi(ref numeri, ref somma);
            Console.WriteLine($"Hai inserito {numeri} numeri e la somma è {somma}");
            Console.ReadLine();

        }

        private static void Leggi(ref int count, ref int somma)
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
                return;
            count++;
            somma += numero;
            Leggi(ref count, ref somma);
        }
    }
}
