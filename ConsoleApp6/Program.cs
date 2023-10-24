using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void finnum() {
                Console.WriteLine("Enter how many numbers you will enter:");
                int numcount = Convert.ToInt32(Console.ReadLine());
                int minuscount = 0;
                int pluscount = 0;
                int zerocount = 0;

                while (numcount > 0)
                {
                    int num = Convert.ToInt32(Console.ReadLine());

                    if (num == 0)
                    {
                        zerocount++;
                    }

                    if (num > 0)
                    {
                        pluscount++;
                    }

                    if (num < 0)
                    {
                        minuscount++;
                    }

                    numcount--;
                }

                Console.WriteLine($"Numbers of negative number:{minuscount}\nNumber of positive number:{pluscount}\nZero Counts:{zerocount}");

            }
            finnum();
        }
    }
}
