using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			Console.Write("输入一个整数：");
			num = int.Parse(Console.ReadLine());
			Console.Write("{0}的素数因子有：1", num);
			for(int i = 2; i <= num; i++)
			{
				if(num % i == 0)
				{
					Console.Write(", {0}", i);
				}
			}
		}
	}
}
