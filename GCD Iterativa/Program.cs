using System;

namespace GCD_Iterativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Máximo común divisor usando iteración");
			Console.Write("Inserte un número: ");
			int numero1 = int.Parse(Console.ReadLine());
			Console.Write("Inserte otro número: ");
			int numero2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("El máximo común divisor es: " + GCD(numero1, numero2));
        }
		static int GCD(int num1, int num2)
		{
			int x;
			while (num2 != 0)
			{
				x = num2;
				num2 = num1%num2;
				num1 = x;
			}
			return num1;
		}
    }
}
