using System;

namespace _1_2_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出一到一百
            int num = 1;
            int sum = 0;
            while (true)
            {
                for (int i = 0; i <100; i++)
                {
                    sum += num;
                    Console.WriteLine(sum);
                }
                break;
            }
        }
    }
}
