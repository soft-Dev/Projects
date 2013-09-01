using System;
using System.Collections.Generic;

namespace prime
{
	class prime
	{
		private static void Main()
		{
			Console.WriteLine("Enter the number you wish to find the prime factors of: ");
			int primeNum = Convert.ToInt32(Console.ReadLine());
			List<int> primes = new List<int>();
			
			for(int i = primeNum - 1; i > 0; i--)
			{
				if(i % 2 != 0)
				{
					if(isPrime(i))
						primes.Add(i);
				}
					
			}
			
			foreach(int item in primes)
				Console.WriteLine(item);
		}
		
		private static bool isPrime(int x)
		{
			bool retVal = false;
			for(int i = 2; i < x; i++)
			{
				if(x % i == 0)
				{
					retVal = false;
					break;
				}
				else
					retVal = true;
			}
			return retVal;
		}
	}
}