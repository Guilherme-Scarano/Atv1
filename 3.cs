using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Por favor, digite um número inteiro positivo.");
        }
        else
        {
            long fatorial = CalcularFatorial(numero);
            Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
        }
    }

    static long CalcularFatorial(int num)
    {
        long resultado = 1;

        for (int i = 1; i <= num; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}