using System;

class Program
{
    enum Menu { Soma = 1, Subtração = 2, Multiplicação = 3, Divisao = 4, Sair = 5 }

    static void Main(String[] args)
    {
        bool escolheuSair = false;
        while (!escolheuSair)
        {
            Console.WriteLine("Seja bem vindo a Calculadora CMD");
            Console.WriteLine("1-Soma \n2-Subtração \n3-Multiplicação \n4-Divisão \n5-SAIR");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case Menu.Soma:
                    Soma();
                    break;

                case Menu.Subtração:
                    Subtração();
                    break;

                case Menu.Multiplicação:
                    Multiplicação();
                    break;

                case Menu.Divisao:
                    Divisão();
                    break;

                case Menu.Sair:
                    escolheuSair = true;
                    break;
            }
            Console.Clear();
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtração()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Multiplicação()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Divisão()
        {
             Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
