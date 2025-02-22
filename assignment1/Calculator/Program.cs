using System;
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个数的值：");
            double a = double.Parse(Console.ReadLine());
            Console.Write("请输入运算符：");
            string s = Console.ReadLine();
            Console.Write("请输入第二个数的值：");
            double b = double.Parse(Console.ReadLine());
            if (s == "+")
            {
                Console.WriteLine("最后结果:"+(a + b));
            }
            else if (s == "-")
            {
                Console.WriteLine("最后结果:" + (a - b));
            }
            else if (s == "*")
            {
                Console.WriteLine("最后结果:" + (a * b));
            }
            else if (s=="/")
            {
                Console.WriteLine("最后结果:" + (a / b));
            }
            else
            {
                Console.WriteLine("没有该运算符");
            }
            Console.Read();
        }
    }
}
