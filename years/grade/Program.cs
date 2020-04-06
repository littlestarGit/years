using System;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            //给分数评级
            Console.WriteLine("请输入分数");
            int grade = int.Parse(Console.ReadLine());
            if(grade>85)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 75)
            {
                Console.WriteLine("B");
            }else if (grade >= 60)
            {
                Console.WriteLine("C");
            }
            else Console.WriteLine("D");
        }
    }
}
