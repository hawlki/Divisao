using System;

namespace divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("---------------------------");
            Console.WriteLine("          Divisão          ");
            Console.WriteLine("---------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Insira aqui um número para ser o numerador: ");
            bool NValido = Decimal.TryParse(Console.ReadLine(), out decimal numerador);
            Console.Write("Insira aqui um número para ser o denominador: ");
            bool DValido = Decimal.TryParse(Console.ReadLine(), out decimal denominador);
            Console.WriteLine();

            if(!NValido || !DValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite somente números");
                Console.ResetColor();
                Environment.Exit(1);
            }

            if(denominador == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O denominador digitado não pode se usado para dividir, por favor insira um número que não seja zero");
                Console.ResetColor();
                Environment.Exit(1);
            }

            else
            {
                decimal resultado = numerador / denominador;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Toque em uma tecla para finalizar o programa");
                Console.ReadKey();

                Console.Clear();
            }

        }
    }
}
