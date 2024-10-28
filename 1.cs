using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        float numero1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        float numero2 = float.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        float numero3 = float.Parse(Console.ReadLine());

        float media = CalcularMedia(numero1, numero2, numero3);

        Console.WriteLine("A média dos três números é: " + media);
    }

    static float CalcularMedia(float num1, float num2, float num3)
    {
        return (num1 + num2 + num3) / 3;
    }
}
