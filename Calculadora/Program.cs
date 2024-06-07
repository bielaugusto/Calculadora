using Calculadora;
using System;
public class Programa
{
    public static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\n----------->>>>>>>>>>  <<<<<<<<<<-----------");
            Console.WriteLine("Escolha o modo da calculadora:");
            Console.WriteLine("1. Padrão");
            Console.WriteLine("2. Científica");
            Console.WriteLine("3. Programador");
            Console.WriteLine("4. Sair\n");
            string escolha = Console.ReadLine();
            Console.WriteLine("----------->>>>>>>>>>  <<<<<<<<<<-----------\n");
            switch (escolha)
            {
                case "1":
                    UsarCalculadoraPadrao();
                    break;
                case "2":
                    UsarCalculadoraCientifica();
                    break;
                case "3":
                    UsarCalculadoraProgramador();
                    break;
                case "4":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida, tente novamente.");
                    break;
            }
        }
    }

    public static void UsarCalculadoraPadrao()
    {
        CalculadoraPadrao calculadora = new CalculadoraPadrao();
        bool voltarAoMenu = false;

        while (!voltarAoMenu)
        {
            Console.WriteLine("\n----------->>>>>>>>>>  <<<<<<<<<<-----------");
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Voltar ao menu principal\n");
            string escolha = Console.ReadLine();
            Console.WriteLine("----------->>>>>>>>>>  <<<<<<<<<<-----------\n");

            switch (escolha)
            {
                case "1":
                    RealizarOperacao(calculadora.Somar);
                    break;
                case "2":
                    RealizarOperacao(calculadora.Subtrair);
                    break;
                case "3":
                    RealizarOperacao(calculadora.Multiplicar);
                    break;
                case "4":
                    RealizarOperacao(calculadora.Dividir);
                    break;
                case "5":
                    voltarAoMenu = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida, tente novamente.");
                    break;
            }
        }
    }

    public static void UsarCalculadoraCientifica()
    {
        CalculadoraCientifica calculadora = new CalculadoraCientifica();
        bool voltarAoMenu = false;

        while (!voltarAoMenu)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Cosseno");
            Console.WriteLine("3. Tangente");
            Console.WriteLine("4. Logaritmo");
            Console.WriteLine("5. Voltar ao menu principal");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    RealizarOperacaoUnica(calculadora.Seno);
                    break;
                case "2":
                    RealizarOperacaoUnica(calculadora.Cosseno);
                    break;
                case "3":
                    RealizarOperacaoUnica(calculadora.Tangente);
                    break;
                case "4":
                    RealizarOperacaoUnica(calculadora.Logaritmo);
                    break;
                case "5":
                    voltarAoMenu = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida, tente novamente.");
                    break;
            }
        }
    }

    public static void UsarCalculadoraProgramador()
    {
        CalculadoraProgramador calculadora = new CalculadoraProgramador();
        bool voltarAoMenu = false;

        while (!voltarAoMenu)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1. E (AND)");
            Console.WriteLine("2. OU (OR)");
            Console.WriteLine("3. XOR");
            Console.WriteLine("4. NÃO (NOT)");
            Console.WriteLine("5. Voltar ao menu principal");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    RealizarOperacaoInt(calculadora.E);
                    break;
                case "2":
                    RealizarOperacaoInt(calculadora.Ou);
                    break;
                case "3":
                    RealizarOperacaoInt(calculadora.Xor);
                    break;
                case "4":
                    RealizarOperacaoUnicaInt(calculadora.Nao);
                    break;
                case "5":
                    voltarAoMenu = true;
                    break;
                default:
                    Console.WriteLine("Escolha inválida, tente novamente.");
                    break;
            }
        }
    }

    public static void RealizarOperacao(Func<double, double, double> operacao)
    {
        Console.Write("Digite o primeiro número: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double resultado = operacao(a, b);
        Console.WriteLine($"Resultado: {resultado}");
    }

    public static void RealizarOperacaoUnica(Func<double, double> operacao)
    {
        Console.Write("Digite o número: ");
        double valor = Convert.ToDouble(Console.ReadLine());
        double resultado = operacao(valor);
        Console.WriteLine($"Resultado: {resultado}");
    }

    public static void RealizarOperacaoInt(Func<int, int, int> operacao)
    {
        Console.Write("Digite o primeiro número (inteiro): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo número (inteiro): ");
        int b = Convert.ToInt32(Console.ReadLine());
        int resultado = operacao(a, b);
        Console.WriteLine($"Resultado: {resultado}");
    }

    public static void RealizarOperacaoUnicaInt(Func<int, int> operacao)
    {
        Console.Write("Digite o número (inteiro): ");
        int valor = Convert.ToInt32(Console.ReadLine());
        int resultado = operacao(valor);
        Console.WriteLine($"Resultado: {resultado}");
    }
}