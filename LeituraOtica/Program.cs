using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite o número de questões:");
            int n = int.Parse(Console.ReadLine());

            int A = 0, B = 0, C = 0, D = 0, E = 0;

            string resposta = "";

            for (int i = 0; i <= n; i++)
            {
                int quantCerta = 0, quantAmbiguidade = 0;

                Console.WriteLine("Digite o valor da alternativa A:");
                A = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da alternativa B:");
                B = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da alternativa C:");
                C = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da alternativa D:");
                D = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da alternativa E:");
                E = int.Parse(Console.ReadLine());

                if (A <= 100)
                {
                    quantCerta++;
                    resposta = "A";
                }

                else if (A >= 155)
                    quantAmbiguidade++;

                if (B <= 100)
                {
                    quantCerta++;
                    resposta = "B";
                }

                else if (B >= 155)
                    quantAmbiguidade++;

                if (C <= 100)
                {
                    quantCerta++;
                    resposta = "C";
                }

                else if (C >= 155)
                    quantAmbiguidade++;

                if (D <= 100)
                {
                    quantCerta++;
                    resposta = "D";
                }

                else if (D >= 155)
                    quantAmbiguidade++;

                if (E <= 100)
                {
                    quantCerta++;
                    resposta = "E";
                }

                else if (E >= 155)
                    quantAmbiguidade++;


                if (quantCerta > 1 || quantAmbiguidade > 4)
                    Console.WriteLine("*");

                else
                    Console.WriteLine("{0}", resposta);
            }

        }
    }
}
