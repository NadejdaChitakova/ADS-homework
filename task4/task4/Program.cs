using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArr = generateArray();
            Console.WriteLine(Contains(5, randomArr) );
            Console.WriteLine(sumOfArray(randomArr) ); 


        }
        static int[] generateArray()
        {
            Random random = new Random();
            int[] randomArr = new int[10];
            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = random.Next(0, 25);
            }
            return randomArr;
        }
        static void CopyArray(int[] arr)
        {
            int[] newArray = new int [arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
        }
        static int Contains(int num, int[] arr)
        {
            for (int i = 0; i <arr.Length ; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }
            return -1;
        }
        static int sumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
