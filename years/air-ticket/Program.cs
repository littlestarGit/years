using System;

namespace air_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算票价
            Console.WriteLine("请输入您的年龄(满岁)");
            int ticket = 500;
            int years = int.Parse(Console.ReadLine());
            if (years > 16)
            {
                Console.WriteLine("您是成人票：{0}元",ticket);
            }
            else
            {
                if (years>5)
                {
                    Console.WriteLine("您是半票：{0}元",ticket/2);
                }
                else if (years >= 0)
                {
                    Console.WriteLine("小朋友你不用交钱");
                }
                else Console.WriteLine("年龄不为负");
            }
        }
    }
}
