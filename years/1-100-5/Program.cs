using System;

namespace _1_100_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出100内数字，且实现换行
            int num = 1, sum = 0;
            while (true)
            {
                for (int i = 0; i <20; i++)
                {
                    for (int e = 0; e < 5; e++)
                    {
                        sum += num;
                        Console.Write("{0}\t",sum);
                    }
                    Console.WriteLine(" ");
                }
                break;
            }
        }
    }
}
