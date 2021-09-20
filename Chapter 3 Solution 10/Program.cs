using System;
					
public class Program
{
	public static void Main()
		{
			string x = Console.ReadLine();
			sum(x);
			inver(x);
			task(x);
		}
		static void sum(string x)
		{
			int sum = 0;
			for (int i = 0; i < x.Length; i++)
			{
				int ele = x[i] - '0';
				sum = sum + ele;
			}
		Console.WriteLine(sum);
		}
	
		static void inver(string x)
		{
			string sum1 = "";
			int loop = x.Length;
			for (int j = loop - 1; j > -1; j--)
			{	
				sum1 = sum1 + x[j];
			}
			Console.WriteLine(sum1);
		}
		static void task(string x)
		{
			string str = "";
			string sum2 = str + x[0] + x[2] + x[1] + x[3] ;
			Console.WriteLine(sum2);
		}
		
	}
