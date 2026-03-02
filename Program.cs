using System;

namespace Calculator
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {   
            Console.Clear();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Resto");
            Console.WriteLine("6 - Potencia");
            Console.WriteLine("0 - Sair");

            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Somar();
            }
            if (escolha == "2")
            {
                Subtrair();
            }
            if (escolha == "3")
            {
                Multiplicar();
            }
            if (escolha == "4")
            {
                Dividir();
            }
            if (escolha == "5")
            {
                Resto();
            }
            if (escolha == "6")
            {
                Potencia();
            }

        }
        public static void Somar()
        {
            double n1, n2;
            Console.WriteLine("Entre com o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(n1 + n2);
            Console.ReadLine();
            Menu();
        }

        public static void Subtrair()
        {
            double n1, n2;
            Console.WriteLine("Entre com o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(n1 - n2);
            Console.ReadLine();
            Menu();
        }
        public static void Multiplicar()
        {
            double n1, n2;
            Console.WriteLine("Entre com o primeiro número");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(n1 * n2);
            Console.ReadLine();
            Menu();
        }
        public static void Dividir()
        {
            double n1, n2;
            Console.WriteLine("Entre com o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            if (n2 != 0)
            {
                Console.WriteLine(n1 / n2);
            } else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            Console.ReadLine();
            Menu();
        }
        public static void Resto()
        {
            double n1, n2;
            Console.WriteLine("Entre com o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(n1 % n2);
            Console.ReadLine();
            Menu();
        }
        public static void Potencia()
        {
            double n1, n2;
            Console.WriteLine("Entre com o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(n1, n2));
            Console.ReadLine();
            Menu();
        }
    }
}