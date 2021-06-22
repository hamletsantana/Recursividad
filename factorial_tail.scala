import scala.annotation.tailrec

object Factorial
{
	def factorial(num: Int): Int = 
	{
		@tailrec def factorialHelp(acum: Int, num: Int): Int =
		{
			if (num <= 1)
				acum
			else
				factorialHelp(num*acum, num-1)
		}
		factorialHelp(1,num)
		
	}
	
	def main (args:Array[String])
	{
		println(factorial(4))
	}
}	
