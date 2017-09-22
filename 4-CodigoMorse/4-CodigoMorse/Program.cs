using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            int com;
            string x;

            Console.WriteLine("Digite o texto");
            x = Console.ReadLine();

            Console.WriteLine("Digite o comando:");
            com = int.Parse(Console.ReadLine());

            string[] tabela = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            string[] letras = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            for (int i = 1; i <= x.Length; i++)
            {
                int n = x[i] - i;

                tabela[n] = letras[n];
            }
        }
    }
}