using System;

namespace weight
{
    class Program
    {
        static void Main(string[] args)
        {
            //按照性别，身高，体重判断是否健康
            Console.WriteLine("请输入您的性别（男/女）");
            string sex = Console.ReadLine();
            Console.WriteLine("请输入您的身高（整数cm）");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入您的体重（整数kg）");
            int weight = int.Parse(Console.ReadLine());
            if (sex == "男")
            {
                int goodweight = height - 100 + 3;
                int goodweight1= height - 100 - 3;
                if (weight - goodweight1 > 0)
                {
                    Console.WriteLine("您偏重，要注意减肥");
                }
                else
                {
                    if(weight - goodweight < 0){
                        Console.WriteLine("您偏瘦，要多锻炼，吃好吃的");
                    }
                    else Console.WriteLine("您的体重是标准体重，继续保持");
                }
            }
            else
            {
                if (sex == "女")
                {
                    int goodweight = height - 110 + 3;
                    int goodweight1 = height - 110 - 3;
                    if (weight - goodweight1 > 0)
                    {
                        Console.WriteLine("您偏重，要注意减肥");
                    }
                    else
                    {
                        if (weight - goodweight < 0)
                        {
                            Console.WriteLine("您偏瘦，要多锻炼，吃好吃的");
                        }
                        else Console.WriteLine("您的体重是标准体重，继续保持");
                    }
                }
            }
        }
    }
}
