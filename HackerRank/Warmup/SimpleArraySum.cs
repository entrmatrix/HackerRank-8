using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Problem Statement

 You are given an array of integers of size N.Can you find the sum of the elements in the array?

 Input
 The first line of input consists of an integer N.The next line contains N space-separated integers representing the array elements.
 Sample:

 6

 1 2 3 4 10 11

 Output
 Output a single value equal to the sum of the elements in the array.
 For the sample above you would just print 31 since 1+2+3+4+10+11=31.
*/

namespace HackerRank.Warmup
{
    class SimpleArraySum
    {
        private static int ArraySum(int arrSize)
        {
            int sum = 0;

            string numbers = Console.ReadLine();

            string[] val = numbers.Split(' ');

            if (val.Length == arrSize)
            {
                foreach (string num in val)
                {
                    sum += Convert.ToInt32(num);                    
                }
            }

            return sum;
        }

        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int sum = ArraySum(n);

        //    Console.WriteLine(sum);
        //    Console.ReadKey();
        //}
    }
}
