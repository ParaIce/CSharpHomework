using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			bool[] nums = new bool[101];
			for(int i = 2; i <= 10; i++)
			{
				int k = i * 2;
				while (k <= 100)
				{
					nums[k] = true;
					k += i;
				}
			}
			Console.Write("2~100以内的素数有：");
			for(int i = 2; i <= 100; i++)
			{
				if (nums[i] == false)
					Console.Write("{0} ", i);
			}
		}
	}
}
