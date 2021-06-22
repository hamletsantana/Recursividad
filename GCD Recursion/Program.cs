using System;

namespace GCD_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Máximo común divisor usando recursión");
			Console.Write("Inserte un número: ");
			int numero1 = int.Parse(Console.ReadLine());
			Console.Write("Inserte otro número: ");
			int numero2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			Console.WriteLine("El máximo común divisor es: " + GCD(numero1, numero2));
        }
		
		static int GCD(int num1, int num2)
		{
			if(num2 == 0)
			{
				return num1;
			}
			else
			{
				return GCD(num2, num1%num2);
			}
		}
    }
}
