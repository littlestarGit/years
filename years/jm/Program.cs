using System;

namespace jm
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断奇偶性
            Console.WriteLine("请输入一个整数");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("整数{0}是偶数",num);
            } else Console.WriteLine("整数{0}是奇数",num);          
        }
    }
}
