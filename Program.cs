using System;

class Program
{
    enum Menu { Soma = 1, Subtração = 2, Multiplicação = 3, Divisao = 4, Potencia = 5, RaizQuadrada = 6, Sair = 7 }

    static void Main(String[] args)
    {
        bool escolheuSair = false;
        while (!escolheuSair)
        {
            Console.WriteLine("Seja bem vindo a Calculadora CMD");
            Console.WriteLine(" 1-Soma \n 2-Subtração \n 3-Multiplicação \n 4-Divisão \n 5-Potencia \n 6-RaizQuadrada \n 7-Sair");

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

                case Menu.Potencia:
                    Potencia();
                    break;

								case Menu.RaizQuadrada:
                    RaizQuadrada();
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
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
			  static void Potencia()
				{
       	 Console.WriteLine("Potecia de um numero: ");
	        Console.WriteLine("Digite a base: ");
	        int baseNum = int.Parse(Console.ReadLine());
	        Console.WriteLine("Digite o expoente: ");
	        int expoente = int.Parse(Console.ReadLine());
	        int resultado = (int)Math.Pow(baseNum, expoente);
	        Console.WriteLine($"O resultado é: {resultado}");
	        Console.WriteLine("Aperte ENTER para voltar para o menu");
	        Console.ReadLine();
	    }
		    static void RaizQuadrada()
	    {
	        Console.WriteLine("Raiz  quadrada de um numero: ");
	        Console.WriteLine("Digite o numero: ");
	        int Num = int.Parse(Console.ReadLine());
	        double resultado = (double)Math.Sqrt(Num);
	        Console.WriteLine($"O resultado é: {resultado}");
	        Console.WriteLine("Aperte ENTER para voltar para o menu");
	        Console.ReadLine();
	    }
	}
}

