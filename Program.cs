using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minha idade em dias:");
            Console.WriteLine();

            DateTime data1, data2, data3;
            TimeSpan result;

            data1 = DateTime.Parse("30/01/2003").Date;
            data2 = DateTime.Parse("30/01/2003").Date;
            data3 = DateTime.Parse("05/06/2020").Date;

            result = data3 - data2;

            Console.WriteLine($"Eu nasci em {data1} e já vivi {result.Days} dias.");

            

        }
    }
}
