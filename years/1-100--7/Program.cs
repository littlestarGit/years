using System;

namespace _1_100__7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, sum = 0;
            while (true)
            {
                
                for (int i = 0; i < 100; i++)
                {
                    sum += num;
                if (sum % 7 == 0)
                {
                    Console.WriteLine(sum);
                }
                }
                break;               
            }
        }
    }
}
