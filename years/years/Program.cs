using System;

namespace years
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断闰年和平年
            Console.WriteLine("请输入年份（如2000,2008）");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0}年为闰年",year);
            }
            else
            {
                Console.WriteLine("{0}年为平年",year);
            }
        }
    }
}
