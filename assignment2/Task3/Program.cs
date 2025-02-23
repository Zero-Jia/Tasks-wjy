namespace Task3
{
    internal class Program
    {
        class ArrayMethod
        {
            public bool isPrime(int x)
            {
                if (x == 2)
                {
                    return true;
                }else if (x > 2)
                {
                    for(int i = 2; i < x; i++)
                    {
                        if (x % i == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[99];
            int n = array.Length;
            bool[] prime = new bool[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = i + 2;
                prime[i] = true;
            }
            ArrayMethod method = new ArrayMethod();
            int[] arrayOfPrime = new int[4];
            for(int i = 0; i < 4; i++)
            {
                arrayOfPrime[i] = 0;
            }
            int index = 0;
            for(int i = 2; i * i < 100; i++)
            {
                if (method.isPrime(i))
                {
                    arrayOfPrime[index] = i;
                    index++;
                }
            }
            foreach(int item in arrayOfPrime)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[j] % item == 0)
                    {
                        prime[j] = false;
                    }
                }
            }
            for(int i = 2; i < 10; i++)
            {
                if (method.isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            for(int i = 0; i < n; i++)
            {
                if (prime[i])
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
