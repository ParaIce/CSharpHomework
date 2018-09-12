using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;
			Console.WriteLine("请输入两个整数：");
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = a * b;
			Console.WriteLine("得到的乘积为{0}", c);
		}
	}
}
