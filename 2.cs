using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool ehPrimo = EhPrimo(numero);

        if (ehPrimo)
        {
            Console.WriteLine("O número " + numero + " é primo.");
        }
        else
        {
            Console.WriteLine("O número " + numero + " não é primo.");
        }
    }

    static bool EhPrimo(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
}
