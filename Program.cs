using System;

namespace Aula22New
{
    class Program
    {
        static void Main(string[] args)
        {
           //Dolar
           Console.WriteLine(ConversorDolar.RealConDolar(52));
           Console.WriteLine(ConversorDolar.DolarConReais(52));
           //Euro
           Console.WriteLine(ConversorEuro.RealConEu(52));
           Console.WriteLine(ConversorEuro.EuConReal(52));

        }
    }
}
