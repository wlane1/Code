using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
//        boolean goUp = true;
//        int cnt = 0;
//for (int i=0; i<18; i++) {
//  if (goUp) { cnt++; }
//  else { cnt--; }
//System.out.println(cnt);
//  if (cnt==3) { goUp = false; }
//  if (cnt==0) { goUp = true; }
//}

        static void Main(string[] args)
        {
            int i = 0;
            int minValue = 0;
            int maxValue = 10;
            int iteratorCount = 0;
            bool goUp = true;

            while (i <= maxValue)
            {
                if (iteratorCount < 1)
                {
                    if (goUp)
                    {
                        i++;
                    }
                    else
                    {
                        i--;
                    }
                    Console.WriteLine($"{i}, ");
                    //Thread.Sleep(1000);
                    if (i == maxValue)
                    {
                        goUp = false;
                    }
                    else if (i == minValue)
                    {
                        goUp = true;
                        iteratorCount++;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
