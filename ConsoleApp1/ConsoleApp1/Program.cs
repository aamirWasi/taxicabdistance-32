using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split(' ');
                int X1, X2, Y1, Y2;
                X1 = int.Parse(space[0]);
                Y1 = int.Parse(space[1]);
                X2 = int.Parse(space[2]);
                Y2 = int.Parse(space[3]);
                int Xdistance = Math.Abs(X1 - X2);
                int Ydistance = Math.Abs(Y1 - Y2);
                int sum = Xdistance + Ydistance;
                Console.WriteLine($"Case {t}: {sum}");
            }
        }
    }
}
