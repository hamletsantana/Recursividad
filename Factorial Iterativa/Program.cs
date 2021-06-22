using System;

namespace Factorial_Iterativa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial versión iterativa");
			Console.Write("Inserte un número: ");
			int numero = int.Parse(Console.ReadLine());
			int factorial = Factorial(numero);
			
			Console.WriteLine(factorial);
        }
		static int Factorial(int num)
		{
			int factorial = 1;
			for (int i = 1; i <= num; i++)
			{
				factorial *= i; 
			}
			return factorial;
		}
    }
}
