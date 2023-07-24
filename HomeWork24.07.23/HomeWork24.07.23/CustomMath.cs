using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork24._07._23
{
	internal class CustomMath
	{
		public int SumOfOddNumbersFromArray(int[] arr)
		{
			int sum = 0;
			foreach (var item in arr)
			{
				if (item % 2 == 1)
				{
					sum += item;
				}
			}
			return sum;
		}

        public int ActionWithEvenNumbersFromArray(int[] arr)
		{
			int sum = 0;
			int result = 1;
			
			foreach (var item in arr)
			{
				if (item % 2 == 0)
				{
					sum+=item;
				}
			}
				result = sum * sum;
			    return result;
		}

		public void Check(int n)
		{
			if (n % 2 == 0)
			{
				Console.WriteLine("Regem cutdur");
			}
			else
			{
                Console.WriteLine("Regem tekdir");
            }   
		}
		public int GetFactorialOfNumber(int n)
		{
			int multiplication = 1;
			for (int i = 1; i < n; i++)
			{
				multiplication *= i;
			}
			return multiplication;
		}
	}
}
