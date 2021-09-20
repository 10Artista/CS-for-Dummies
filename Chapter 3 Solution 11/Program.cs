using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Solution_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35, p = 6, i = 1, mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");            
        }
    }
}

using System;
					
public class Program
{
	public static void Main()
		{
			string Number = Console.ReadLine();
			string Position = Console.ReadLine();
			int Num = Int16.Parse(Number);
			int Pos = Int16.Parse(Position);
			string binary = Convert.ToString(Num, 2);
			Console.WriteLine(binary);
			Console.WriteLine(binary[Pos]);
		}
		
	}

