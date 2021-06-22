import scala.annotation.tailrec

object Sumatoria
{
	def Sumatoria(num: Int): Int = 
	{
		@tailrec 
		def sumatoria(num: Int, x: Int = 0): Int =
		{
			if (num <= 0)
				x
			else
				sumatoria(num-1, x+num)
		}
		sumatoria(num)
		
	}
	
	def main (args:Array[String])
	{
		println(Sumatoria(2))
	}
}	