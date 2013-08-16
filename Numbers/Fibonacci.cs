using System;

namespace fibonacci
{
	class fibonacci
	{
		private static void Main()
		{
			Console.WriteLine("Please enter your maximum number: ");
			int topNum = Convert.ToInt32(Console.ReadLine());
			int curNum = 1; int priNum = 0; int newNum = 0;
			do
			{
				if(curNum == 1 && priNum == 0)
				{
					Console.WriteLine("The first number in the Fibonacci Sequence is: " + priNum);
					Console.WriteLine("The next number in the Fibonacci Sequence is: " + curNum);
					priNum = curNum;
				}
				else
				{
					Console.WriteLine("The next number in the Fibonacci Sequence is: " + curNum);
					newNum = curNum;
					curNum += priNum;
					priNum = newNum;
				}
				
				
			} while(curNum <= topNum);
		}
	}
}