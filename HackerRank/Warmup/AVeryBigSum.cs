using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem Statement

You are given an array of integers of size N. You need to print the sum of the elements in the array, 
keeping in mind that some of those integers may be quite large.

Input

The first line of the input consists of an integer N. The next line contains N space-separated integers 
contained in the array.

Constraints
1≤N≤10
0≤A[i]≤1010

Sample Input

5
1000000001 1000000002 1000000003 1000000004 1000000005

Output
Print a single value equal to the sum of the elements in the array. In the above sample, you would print 5000000015.
*/

namespace HackerRank.Warmup
{
    class AVeryBigSum
    {
       private static long BigSum(int n)
        {
            long sum = 0;
            
            string numbers = Console.ReadLine();

            string[] val = numbers.Split(' ');

            if (val.Length == n)
            {
                foreach (string num in val)
                {
                    sum += Convert.ToInt64(num);
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long sum = 0;

            if (n >= 1 && n <= 10)
            {
                 sum = BigSum(n);
                 Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("1 <= N <= 10");
            }           

            Console.ReadKey();
        } 
    }
}
