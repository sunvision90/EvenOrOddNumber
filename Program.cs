using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usernumber = 0;

            while (true)
            {
                Console.WriteLine("\nWpisz dowolną liczbę a ja sprawdzę czy jest ona parzysta czy nieparzysta. Dla wyjścia wpisz exit.");
                string input = (Console.ReadLine());

                if (input.ToLower()=="exit")
                {
                    break;
                }

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Nie podano żadnej wartości");
                    continue;
                }
                try { 

                   usernumber = int.Parse(input);
                                 
                   
                    if (usernumber % 2 == 0)
                    {
                        Console.WriteLine("Liczba ta jest parzysta");

                        continue;
                    }
                    else
                    {

                        Console.WriteLine("liczba ta jest nieparzysta");
                        continue;

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Podana wartość nie jest liczbą. Spróbuj ponownie.");

                }
                


            }
            Console.WriteLine("Do widzenia.");
        }
    }
}
