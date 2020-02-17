using System;
using System.Collections.Generic;
using System.Linq;

namespace BrothersInTheBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"brothersInTheBar(glasses) = {FindRounds()}");
        }

        public static int[] CreateArray()
        {
            int[] array = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            return array;
        }

        public static int FindRounds()
        {
            int[] array = CreateArray();
            int rounds = 0;
            var list=new List<int>(array);
            for (int i = 0; i < list.Count-2; i++)
            {
                if (list[i]== list[i+1] && list[i]== list[i+2])
                {
                    rounds++;
                    list.RemoveRange(i,3);
                    i=0;
                }
            }
            return rounds;
        }
    }
}
