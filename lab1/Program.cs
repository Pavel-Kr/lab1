using System;

namespace lab1
{
    public class HW1
    {
        public static long QueueTime(int[] customers,int n)
        {
            int[] queue = new int[n];
            for(int i = 0; i < customers.Length; i++)
            {
                int min = 0;
                for(int j = 0; j < n; j++)
                {
                    if (queue[j] < queue[min]) min = j;
                }
                queue[min] += customers[i];
            }
            int max = 0;
            foreach(int x in queue)
            {
                if (x > max) max = x;
            }
            return max;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] customers = { 5, 3, 4 };
            Console.WriteLine(HW1.QueueTime(customers, 1));
        }
    }
}
