using System;

namespace ConsoleApp1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string tc = Console.ReadLine();
			if (tc.Length <= 10)
			{
				int TC = int.Parse(tc);
				int TF = TC * 9 / 5 + 32;
				Console.WriteLine($"{TF}");
			}
			else
			{
				Console.WriteLine("Ввод неверный");
			}
		}
	}
}