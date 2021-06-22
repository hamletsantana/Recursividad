using System;

namespace Factorial_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial de un numero usando recursion");
			Console.Write("Inserte un número: ");
			int numero = int.Parse(Console.ReadLine());
			int factorial = Factorial(numero);
			
			Console.WriteLine(factorial);
        }
		
		static int Factorial(int num)
		{
			if(num > 1)
			{
				num = num*Factorial(num-1);
			}
			return num;
			
		}
    }
}
