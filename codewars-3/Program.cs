using System;

namespace codewars_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 2, 1, 2 };
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine("------");
            Maps(x);
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
        public static int[] Maps(int[] x)
        {

            for (int i = 0;i<x.Length;i++)
            {
                x[i] = x[i] + x[i];
            }
            return x;
        }
    }
}
