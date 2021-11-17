using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleHW
{
    internal class Program
    {
       
        static void ArrayReverse(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} {(array, array[i])}");
            }
                for (int j = array.Length; j>=0; j--)
                {
                    Console.WriteLine(array[j]);
                } 
        }
        static void SumOfOddIndex(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} {(array, array[i])}");
            }
            int sum = 0;
            int Index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Index = i;
                if (Index%2!=0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
        static void MaxElementAndIndex(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} {(array, array[i])}");
            }
            int max = array[0], maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Index:{maxIndex}");
            Console.WriteLine($"Number:{max}");
        }
        static void MinElementAndIndex(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} {(array, array[i])}");
            }
            int min = array[0], minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            Console.WriteLine($"Index:{minIndex}");
            Console.WriteLine($"Number:{min}");
        }
        static void Main(string[] args)
        {
            ArrayReverse(args);
            //SumOfOddIndex(args);
            //MaxElementAndIndex(args);
            //MinElementAndIndex(args);
        }
    }
}
