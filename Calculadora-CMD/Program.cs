using System;
using System.Globalization;

namespace Calculadora_CMD
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        static void Main(string[] args)
        {

            bool opcaoSair = false;
            while (!opcaoSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        opcaoSair = true;
                        break;
                }

                Console.Clear();

            }
        }

        static void Soma()
        {
            Console.WriteLine("A SOMA ENTRE DOIS NÚMEROS!");
            Console.Write("Digite o Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine($"O RESULTADO é: {resultado}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("A SUBTRAÇÃO ENTRE DOIS NÚMEROS!");
            Console.Write("Digite o Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 - numero2;
            Console.WriteLine($"O RESULTADO é: {resultado}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("A DIVISÃO ENTRE DOIS NÚMEROS!");
            Console.Write("Digite o Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            double resultado = (double)numero1 / numero2;
            Console.WriteLine($"O RESULTADO é: {resultado}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("A MULTIPLICAÇÃO ENTRE DOIS NÚMEROS!");
            Console.Write("Digite o Primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 * numero2;
            Console.WriteLine($"O RESULTADO é: {resultado}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }

        static void Potencia()
        {
            CultureInfo culture = CultureInfo.InvariantCulture;
            Console.WriteLine("A POTÊNCIA DE UM NÚMERO!");
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expoente);
            Console.WriteLine($"O RESULTADO é: {resultado.ToString("f2", culture)}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
        static void Raiz()
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            Console.WriteLine("A RAIZ DE UM NÚMERO!");
            Console.Write("Digite o número: ");
            int numero1 = int.Parse(Console.ReadLine());
            double resultado = (double)Math.Sqrt(numero1);
            Console.WriteLine($"O RESULTADO é: {resultado.ToString("f2", culture)}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Aperte ENTER para voltar para o menu.");
            Console.ReadLine();
        }
    }
}
