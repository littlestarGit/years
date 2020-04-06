using System;

namespace _1_100_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出1-100中的偶数
            int num = 1;
            int sum = 0;
            while (true)
            {
                for (int i = 0; i <100; i++)
                {
                    sum += num;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine(sum);
                    }
                }
                break;
            }
        }
    }
}
