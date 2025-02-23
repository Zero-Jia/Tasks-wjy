using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个正整数：");
            int num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine("请输入大于 1 的正整数。");
                return;
            }

            Console.Write($"{num} 的素数因子是：");

            while (num % 2 == 0)
            {
                Console.Write("2 ");
                num = num / 2;
            }

            for (int i = 3; i * i <= num; i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write($"{i} ");
                    num = num / i;
                }
            }

            if (num > 2)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
        }
    }
}
