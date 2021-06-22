import scala.annotation.tailrec

object GCD
{
	def GCD(num_1: Int, num_2: Int): Int = 
	{
		@tailrec 
		def GCDFunc(num1: Int, num2: Int): Int =
		{
			if (num2 == 0)
				num1
			else
				GCDFunc(num2, num1%num2)
		}
		GCDFunc(num_1,num_2)
		
	}
	
	def main (args:Array[String])
	{
		println(GCD(4,2))
	}
}	