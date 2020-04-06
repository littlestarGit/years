using System;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断时间的分区
            Console.WriteLine("现在几点了");
            int hour = int.Parse(Console.ReadLine());
            if (hour >= 0 && hour <= 24)
            {
                if (hour < 6)
                {
                    Console.WriteLine("现在是凌晨{0}点",hour);
                }
                else
                {
                    if (hour <=12)
                    {
                        Console.WriteLine("现在是上午{0}点",hour);
                    }
                    else
                    {
                        if (hour < 18)
                        {
                            Console.WriteLine("现在是下午{0}点",hour-12);
                        }
                        else
                        {
                            Console.WriteLine("现在是晚上{0}点",hour-12);
                        }
                    }
                }
            }
            else Console.WriteLine("请输入0-24的数字");
        }
    }
}
