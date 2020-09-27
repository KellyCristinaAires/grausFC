using System;

namespace grausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit;
            double Celsius = 97;

            Console.Write("Digite seu valor Fahrenheit: ");
            Fahrenheit = double.Parse(Console.ReadLine());

            Celsius = (Fahrenheit -32) / 1.8;
            Console.WriteLine("Fahrenheit para Celsius = {0}", Celsius);
            Console.Write("\n");

            Console.WriteLine("Pressione Enter para sair!");
            Console.ReadKey();
        }
    }
}