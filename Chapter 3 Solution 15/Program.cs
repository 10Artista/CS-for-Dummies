using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Solution_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << 3;
            int bitAt3 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 4;
            int bitAt4 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 5;
            int bitAt5 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 24;
            int bitAt24 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 25;
            int bitAt25 = (v & mask) != 0 ? 1 : 0;
            mask = 1 << 26;
            int bitAt26 = (v & mask) != 0 ? 1 : 0;

            v = (bitAt3 == 0) ? v = v & (~(1 << 24)) : v = v | (1 << 24);
            v = (bitAt4 == 0) ? v = v & (~(1 << 25)) : v = v | (1 << 25);
            v = (bitAt5 == 0) ? v = v & (~(1 << 26)) : v = v | (1 << 26);
            v = (bitAt24 == 0) ? v = v & (~(1 << 3)) : v = v | (1 << 3);
            v = (bitAt25 == 0) ? v = v & (~(1 << 4)) : v = v | (1 << 4);
            v = (bitAt26 == 0) ? v = v & (~(1 << 5)) : v = v | (1 << 5);

            Console.WriteLine(v);
        }
    }
}

// visule observation 
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter number: ");
        int v = Convert.ToInt32(Console.ReadLine());
        int mask1 = 1 << 3;
        int bitAt3 = (v & mask1) != 0 ? 1 : 0;
        int mask2 = 1 << 4;
        int bitAt4 = (v & mask2) != 0 ? 1 : 0;
        int mask3 = 1 << 5;
        int bitAt5 = (v & mask3) != 0 ? 1 : 0;
        int mask4 = 1 << 24;
        int bitAt24 = (v & mask4) != 0 ? 1 : 0;
        int mask5 = 1 << 25;
        int bitAt25 = (v & mask5) != 0 ? 1 : 0;
        int mask6 = 1 << 26;
        int bitAt26 = (v & mask6) != 0 ? 1 : 0;

        string binary1 = Convert.ToString(v, 2);
        string binary2 = Convert.ToString((~(1 << 3)), 2);
        string binary3 = Convert.ToString((~(1 << 4)), 2);
        string binary4 = Convert.ToString((~(1 << 5)), 2);
        string binary5 = Convert.ToString((~(1 << 24)), 2);
        string binary6 = Convert.ToString((~(1 << 25)), 2);
        string binary7 = Convert.ToString((~(1 << 26)), 2);

        string result1 = Convert.ToString((v & (~(1 << 3))), 2);
        string result2 = Convert.ToString((v & (~(1 << 4))), 2);
        string result3 = Convert.ToString((v & (~(1 << 5))), 2);
        string result4 = Convert.ToString((v & (~(1 << 24))), 2);
        string result5 = Convert.ToString((v & (~(1 << 25))), 2);
        string result6 = Convert.ToString((v & (~(1 << 26))), 2);

        string result7 = Convert.ToString((v | (~(1 << 3))), 2);
        string result8 = Convert.ToString((v | (~(1 << 4))), 2);
        string result9 = Convert.ToString((v | (~(1 << 5))), 2);
        string result10 = Convert.ToString((v | (~(1 << 24))), 2);
        string result11 = Convert.ToString((v | (~(1 << 25))), 2);
        string result12 = Convert.ToString((v | (~(1 << 26))), 2);

        if (bitAt3 == 0)
        {
            Console.WriteLine("it's zero");
            Console.WriteLine(binary1);
            Console.WriteLine(binary2);
            Console.WriteLine(result1);
            Console.WriteLine(Convert.ToInt32(result1, 2));
        }
        else
        {
            Console.WriteLine(binary1);
            Console.WriteLine(binary2);
            Console.WriteLine(result7);
            Console.WriteLine(Convert.ToInt32(result7, 2));
        }
        if ((bitAt4 == 0))
        {
            Console.WriteLine("it's zero");
            Console.WriteLine(binary1);
            Console.WriteLine(binary3);
            Console.WriteLine(result2);
            Console.WriteLine(Convert.ToInt32(result2, 2));
        }
        else
        {
            Console.WriteLine(binary1);
            Console.WriteLine(binary3);
            Console.WriteLine(result8);
            Console.WriteLine(Convert.ToInt32(result8, 2));
        }

        if (bitAt5 == 0)
        {
            Console.WriteLine("it's zero");
            Console.WriteLine(binary1);
            Console.WriteLine(binary4);
            Console.WriteLine(result3);
            Console.WriteLine(Convert.ToInt32(result3, 2));
        }
        else
        {
            Console.WriteLine(binary1);
            Console.WriteLine(binary4);
            Console.WriteLine(result9);
            Console.WriteLine(Convert.ToInt32(result9, 2));
        }

        if (bitAt24 == 0)
        {
            Console.WriteLine("it's zero");
            Console.WriteLine(binary1);
            Console.WriteLine(binary5);
            Console.WriteLine(result4);
            Console.WriteLine(Convert.ToInt32(result4, 2));
        }
        else
        {
            Console.WriteLine(binary1);
            Console.WriteLine(binary5);
            Console.WriteLine(result10);
            Console.WriteLine(Convert.ToInt32(result10, 2));
        }

        if (bitAt25 == 0)
        {
            Console.WriteLine("it's zero");
            Console.WriteLine(binary1);
            Console.WriteLine(binary6);
            Console.WriteLine(result5);
            Console.WriteLine(Convert.ToInt32(result5, 2));
        }
        else
        {
            Console.WriteLine(binary1);
            Console.WriteLine(binary6);
            Console.WriteLine(result11);
            Console.WriteLine(Convert.ToInt32(result11, 2));
        }

        if (bitAt26 == 0)
        {
            Console.WriteLine("it's zero");
            Console.WriteLine(binary1);
            Console.WriteLine(binary7);
            Console.WriteLine(result6);
            Console.WriteLine(Convert.ToInt32(result6, 2));
        }
        else
        {
            Console.WriteLine(binary1);
            Console.WriteLine(binary7);
            Console.WriteLine(result12);
            Console.WriteLine(Convert.ToInt32(result12, 2));
        }


        v = (bitAt3 == 0) ? v & (~(1 << 3)) : v | (1 << 3);
        Console.WriteLine(v);
        v = (bitAt4 == 0) ? v & (~(1 << 4)) : v | (1 << 4);
        Console.WriteLine(v);
        v = (bitAt5 == 0) ? v & (~(1 << 5)) : v | (1 << 5);
        Console.WriteLine(v);
        v = (bitAt24 == 0) ? v & (~(1 << 24)) : v | (1 << 24);
        Console.WriteLine(v);
        v = (bitAt25 == 0) ? v & (~(1 << 25)) : v | (1 << 25);
        Console.WriteLine(v);
        v = (bitAt26 == 0) ? v & (~(1 << 26)) : v | (1 << 26);
        Console.WriteLine(v);
        Console.WriteLine();
    }
}


