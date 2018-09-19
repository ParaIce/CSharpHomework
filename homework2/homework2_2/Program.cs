using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 65, 15, 42, 60, 2, 48, 71, 29, 36 };
			int max = nums[0], min = nums[0], sum = 0;
			Console.Write("数组中的元素为：");
			foreach(int num in nums)
			{
				
				Console.Write("{0} ", num);
				if (num > max)
					max = num;
				else if (num < min)
					min = num;
				sum += num;
			}
			Console.Write("\n");
			Console.WriteLine("数组最大值为：{0}", max);
			Console.WriteLine("数组最小值为：{0}", min);
			Console.WriteLine("数组平均值为：{0}", sum / nums.Length);
			Console.WriteLine("数组元素的和为：{0}", sum);
		}
	}
}
