using System;

namespace _1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-100 7的倍数
            Console.WriteLine("请输入一个0-100的数字");
            int num = int.Parse(Console.ReadLine());
            if (num >= 0 && num <= 100)
            {
                if (num % 7 == 0)
                {
                    int num1 = num / 7;
                    Console.WriteLine("数字{0}是7的{1}倍",num,num1);
                }
                else Console.WriteLine("数字{0}不是7的倍数",num);
            }
            else Console.WriteLine("您输入的数字偏大或小了");
        }
    }
}
