namespace Task4
{
    internal class Program
    {
        class Method
        {
            public bool isToeplitz(int n, int[][] maxtrix)
            {
                int temp = maxtrix[0][0];
                for(int i = 0; i < n; i++)
                {
                    if (maxtrix[i][i] != temp)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{5,1,2,3},
                new int[]{9,5,1,2}
            };
            int[][] matrix2 = new int[][]
            {
                new int[]{1,2,3,4},
                new int[]{5,1,2,3},
                new int[]{9,5,6,2}
            };
            int x1 = matrix1.GetLength(0);
            int x2 = matrix1[0].GetLength(0);
            int n = x1 >= x2 ? x2 : x1;
            Method method = new Method();
            bool result1 = method.isToeplitz(n, matrix1);
            Console.WriteLine(result1);
            bool result2 = method.isToeplitz(n, matrix2);
            Console.WriteLine(result2);
        }
    }
}
