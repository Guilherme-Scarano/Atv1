using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a base: ");
        int baseNumero = int.Parse(Console.ReadLine());

        Console.Write("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        int resultado = CalcularPotencia(baseNumero, expoente);

        Console.WriteLine("O resultado de " + baseNumero + " elevado a " + expoente + " é: " + resultado);
    }

    static int CalcularPotencia(int baseNum, int exp)
    {
        int resultado = 1;

        for (int i = 0; i < exp; i++)
        {
            resultado *= baseNum;
        }

        return resultado;
    }
}