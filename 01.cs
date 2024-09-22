using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("O número 0 pertence à sequência!");
                return;
            }
            if (num == 1)
            {
                Console.WriteLine("O número 1 pertence à sequência!");
                return;
            }
            int n1 = 0;
            int n2 = 1;
            int soma = 0;
            
            bool validar = false;
            Console.WriteLine("Sequência: ");
            Console.Write($"{n1} {n2} ");
            for (int i = 2; i < num; i++)
            {
                soma = n1 + n2;
                if (soma == num)
                {
                    validar = true;
                }
                Console.Write(soma + " ");

                n1 = n2;
                n2 = soma;
            }
            Console.WriteLine();
            if (validar)
            {
                Console.WriteLine($"O número {num} pertence a sequência!");
            }
            else
            {
                Console.WriteLine($"O número {num} não pertence a sequência!");
            }
        }
    }
}
