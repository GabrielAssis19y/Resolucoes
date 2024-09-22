using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a palavra: ");
            string palavra = Console.ReadLine();
            int cont = 0;
            bool validar = false;

            for (int i = 0;i < palavra.Length; i++)
            {
                if (palavra[i] == 'a' || palavra[i] == 'A')
                {
                    validar = true;
                    cont++;
                }
            }
            if (validar)
            {
                Console.WriteLine($"A palavra contém a letra 'A', ocorrendo {cont} vez(es).");
            }
            else
            {
                Console.WriteLine("A palavra não contém a letra 'A'");
            }

        }
    }
}
