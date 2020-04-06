using System;

namespace year_day
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断该年该月的天数
            Console.WriteLine("请输入您需要的年份");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入您需要的月份");
            int month = int.Parse(Console.ReadLine());
            if (month >= 1 && month <= 12)
            {
             if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                Console.WriteLine("{0}年{1}月有31天",year,month);
            }
            else
            {
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        Console.WriteLine("{0}年{1}月有30天",year,month);
                    }
                    else
                    {
                        if(year%4==0&&year%100!=0||year%400==0)
                        {
                            Console.WriteLine("{0}年{1}月有29天",year,month);
                        }
                        else Console.WriteLine("{0}年{1}月有28天",year,month);
                    }
            }
            }
            else Console.WriteLine("您输入的月份有误");
           
        }
    }
}
