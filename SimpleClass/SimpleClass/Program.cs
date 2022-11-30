// See https:/using System;

using System.ComponentModel.DataAnnotations;

namespace SimpleClass // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("Grå");

            Console.WriteLine(c1.Farve);

            c1.nyFarve();

            Console.WriteLine(c1.Farve);
        }
    }
}