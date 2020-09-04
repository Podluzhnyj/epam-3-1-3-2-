using System;
using System.Collections.Generic;

namespace Module3_2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            throw new NotSupportedException();
        }
    }

    public class Task4
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        { 
            if (Int32.TryParse(input, out result))
            {
                throw new ArgumentException();

            }
            else return false;
        }

        public int[] GetFibonacciSequence(int n)
        {
            int[] a = new int[n];
            try
            {
                if (n <= 0)
                {
                    throw new OverflowException();


                }
                else
                {
                    a[0] = 0;
                    a[1] = 1;
                    for (int i = 2; i < n; i++)
                    {
                        a[i] = a[i - 1] + a[i - 2];
                        Console.WriteLine(a[i]);
                    }
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return a;
        }
    }

    public class Task5
    {
        public int ReverseNumber(int sourceNumber)
        {
            int reverse = 0, rem;
            while (sourceNumber != 0)
            {
                rem = sourceNumber % 10;
                reverse = reverse * 10 + rem;
                sourceNumber /= 10;
            }
            return reverse;
        }
    }

    public class Task6
    {
        /// <summary>
        /// Use this method to generate array. It shouldn't throws exception.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            try
            {
                
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next();
                    Console.WriteLine(array[i]);
                }
            }
            catch
            {
                throw new OutOfMemoryException();
            }
            return array;
        }


        public int[] UpdateElementToOppositeSign(int[] source)
        {
            try
            {
                int n = source.Length;
                for (int k = 0; k < n; k++)
                {
                    source[k] = source[k] * -1;
                    Console.WriteLine(source[k]);
                    
                }
            }
            catch
            {
                throw new OverflowException();
            }
            return source;
        }
       
        
    }

  


    public class Task7
    {
        /// <summary>
        /// Use this method to generate array. It shouldn't throws exception.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            int[] array = new int[size];
            try
            {
                
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next();
                    Console.WriteLine(array[i]);
                }
            }
            catch
            {
                throw new OverflowException();
            }
            return array;
        }

        public List<int> FindElementGreaterThenPrevious(int[] source)
        {
            List<int> list = new List<int>();
            try
            {  
                int n = 0;

                for (int i = 0; i < source.Length - 1; i++)
                {
                    if (source[i] < source[i + 1])
                    {
                        n++;
                    }
                }

                Console.WriteLine(n);
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
            
            return list;
        }
    }

    public class Task8
    {
        public int[,] FillArrayInSpiral(int size)
        {
            int[,] mass = new int[size, size];
            try
            {
                int a1 = 0, a2 = 3, b1 = 0, b2 = 3, n = 0;

                while (size == 4)
                {
                    for (int i = a1; i < a2 + 1; i++)
                    {
                        n++;
                        mass[i, b1] = n;
                    }
                    if (n == 16)
                        break;
                    for (int j = b1 + 1; j < b2 + 1; j++)
                    {
                        n++;
                        mass[a2, j] = n;
                    }
                    if (n == 16)
                        break;
                    for (int i = a2 - 1; i > a1 - 1; i--)
                    {
                        n++;
                        mass[i, b2] = n;
                    }
                    if (n == 16)
                        break;
                    for (int j = b2 - 1; j > b1; j--)
                    {
                        n++;
                        mass[a1, j] = n;
                    }
                    if (n == 16)
                        break;


                    a1++;
                    a2--;
                    b1++;
                    b2--;

                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{mass[j, i]} ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return mass;

            
        }
    }
}

