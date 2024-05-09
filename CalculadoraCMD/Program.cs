using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCMD
{
    internal class Program
    {
        enum menu 
        { 
            Adicao = 1, 
            Subtracao, 
            Divisao,
            Multiplicacao,
            Raiz, 
            Potencia,
            Sair = 0
        }
        static void Main()
        {
            bool rodar = true;
            while (rodar)
            {
                Console.WriteLine("Seja bem-vindo a calculadora em C#. Selecione uma opção a seguir:");
                Console.WriteLine("1-Adição\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Raíz\n6-Potência\n0-Sair");

                menu escolha = (menu)int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case menu.Adicao:
                        Adicao();
                    break;
                    case menu.Subtracao:
                        Subtracao();
                    break;
                    case menu.Divisao:
                        Divisao();
                    break;
                    case menu.Multiplicacao:
                        Multiplicacao();
                    break;
                    case menu.Potencia:
                        Potencia();
                    break;
                    case menu.Raiz:
                        Raiz();
                    break;
                    case menu.Sair:
                        rodar = false;
                    break;
                }

                Console.Clear();
            }
        }
        static void Adicao()
        {
            Console.WriteLine("Adição de dois números:");

            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números:");

            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números:");

            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números:");

            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Número elevado a potência:");

            Console.WriteLine("Digite o número a ser elevado:");
            float numbase = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da potência:");
            float numpotencia = float.Parse(Console.ReadLine());

            Console.WriteLine($"{numbase} ^ {numpotencia} = {Math.Pow(numbase, numpotencia)}");

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raíz quadrada de um número:");

            Console.WriteLine("Digite o número que terá a raíz calculada:");
            float numbase = float.Parse(Console.ReadLine());

            Console.WriteLine($"Raíz de {numbase} = {Math.Sqrt(numbase).ToString("F3")}");

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
