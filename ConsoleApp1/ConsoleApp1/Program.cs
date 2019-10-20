using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una tarjeta de credito");
            string texto = Console.ReadLine();
            Regex miRegex = new Regex(@"^\d{4}[ -]?\d{4}[ -]?\d{4}[ -]?(\d{4})$");
            if (miRegex.IsMatch(texto))
            {
                var match = miRegex.Match(texto);
                Console.WriteLine($"Los ultimos cuatro numeros son: {match.Groups[1]}");
            }
            else {
                Console.WriteLine("No es una tarjeta");
            }
           
            Console.ReadKey();
        }
    }
}
