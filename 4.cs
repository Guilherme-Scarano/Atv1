using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = ConverterParaFahrenheit(celsius);

        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
    }

    static double ConverterParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}