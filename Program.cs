using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double conta;

            Console.WriteLine("insira números positivos:");
            n1 = Double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("insira números positivos:");
                n1 = Double.Parse(Console.ReadLine());
            }
            while (n1 < 0);
            {
                Console.WriteLine("insira o segundo número somente positivos:");
                n2 = Double.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("insira o segundo número somente positivos:");
                n2 = Double.Parse(Console.ReadLine());

            }
            while (n2 < 0);
            {
                conta = n1 + n2;
                Console.WriteLine("O resultado da soma é:{0}",conta);
            }
                
        }
    }
}
