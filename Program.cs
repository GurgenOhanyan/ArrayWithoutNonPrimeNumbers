using System;
using System.Threading.Tasks;
namespace PrimeNumbersWithParalellism
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Initialization(array);
            Print(array);
            Console.WriteLine();
            WithoutNonPrimeNumbers(array);

        }
        static void Initialization(int [] arr)
        {
            Random rnd = new Random();
            Parallel.For(0, arr.Length, i =>
            {
                arr[i] = rnd.Next(10, 20);

            });
        }
        static void Print(int[] arr)
        {
            Parallel.For(0, arr.Length, i =>
            {
                Console.Write(arr[i]+"  ");
            });
        }

        static void WithoutNonPrimeNumbers(int[] arr)
        {
            Parallel.For(0, arr.Length, i =>
            {
                bool isPrime = true;
                for (int j = 2; j <arr[i]/2; j++)
                {
                    if(arr[i]%j==0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    Console.Write(arr[i]+"  ");
                }

            });
        
        }

    }
}
