using System.Security;

namespace Task2
{
    internal class Program
    {
        class ArrayMethod
        {
            public int getMax(int[] array)
            {
                int max = array[0];
                int n = array.Length;
                for(int i = 0; i < n; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            public int getMin(int[] array)
            {
                int min = array[0];
                int n = array.Length;
                for (int i = 0; i < n; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            public int getSum(int[] array)
            {
                int sum = 0;
                int n = array.Length;
                for (int i = 0; i < n; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
            public double getAvg(int[] array)
            {
                int n = array.Length;
                int sum = getSum(array);
                return sum / n;
            }
        }
        static void Main(string[] args)
        {
            int[] example = new int[] { 1, 3, 5, 7, 9 };
            ArrayMethod method = new ArrayMethod();
            Console.WriteLine("数组最大值为：" + method.getMax(example));
            Console.WriteLine("数组最小值为：" + method.getMin(example));
            Console.WriteLine("数组数之和为：" + method.getSum(example));
            Console.WriteLine("数组的平均值为：" + method.getAvg(example));
        }
    }
}
