using System;
using System.Linq;

namespace M4
{
    public class Module4
    {
        static void Main(string[] args)
        {
        }


        public int Task_1_A(int[] array)
        {

            try
            {
                int maxValue = array.OrderByDescending(x => x).Max();
                Console.WriteLine(maxValue);
                return maxValue;
            }
            catch
            {
                throw new ArgumentNullException();
            }

        }

        public int Task_1_B(int[] array)
        {
            try
            {
                int minValue = array.OrderByDescending(x => x).Min();
                Console.WriteLine(minValue);
                return minValue;
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }

        public int Task_1_C(int[] array)
        {
            int sumValue=0;
            try
            {
                 sumValue = array.OrderByDescending(x => x).Sum();
                Console.WriteLine(sumValue);
               
            }
            catch (Exception)
            {
                
            }
            return sumValue;
        }

        public int Task_1_D(int[] array)
        {
            try
            {
                int max = array.Max(x => x);
                int min = array.Min(x => x);
                int result = max - min;
                Console.WriteLine(result);
                return result;
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }

        public void Task_1_E(int[] array)
        {
            try
            {
                int max = array.Max(x => x);
                int min = array.Min(x => x);
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0) array[i] -= min;
                    else array[i] += max;
                    Console.WriteLine(array[i] + "");

                }
            }
            catch
            {
                throw new ArgumentNullException();
            }

        }

        public int Task_2(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Task_2(int a, int b)
        {
            return a + b;
        }

        public double Task_2(double a, double b, double c)
        {
            return a + b + c;
        }

        public string Task_2(string a, string b)
        {
            string sum = a + "" + b;
            string result = String.Concat(sum);
            Console.WriteLine(result);
            return result;
        }

        public int[] Task_2(int[] a, int[] b)
        {

                for (int i = 0; i < b.Length; i++)
                    if (i < a.Length)
                        a[i] = a[i] + b[i];
                    else
                        a[i] = b[i];

                Array.ForEach(a, x => Console.Write(x + ""));
                return a;

        }

        public void Task_3_A(ref int a, ref int b, ref int c)
        {
            a += 10;
            b += 10;
            c += 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }

        public void Task_3_B(double radius, out double length, out double square)
        {
            try
            {
                length = 2 * Math.PI * radius;
                square = Math.PI * radius * radius;
                Console.WriteLine(length);
                Console.WriteLine(square);
            }
            catch
            {
                throw new Exception();
            }
        }

        public void Task_3_C(int[] array, out int maxItem, out int minItem, out int sumOfItems)
        {

            maxItem = array.Max(x => x);
            minItem = array.Min(x => x);
            sumOfItems = array.Sum();
            Console.WriteLine(maxItem);
            Console.WriteLine(minItem);
            Console.WriteLine(sumOfItems);

        }

        public (int, int, int) Task_4_A((int, int, int) numbers)
        {
            numbers.Item1 += 10;
            numbers.Item2 += 10;
            numbers.Item3 += 10;
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            return numbers;
        }

        public (double, double) Task_4_B(double radius)
        {
            double length = 2 * Math.PI * radius;
            double square = Math.PI * radius * radius;
            var result = (length, square);
            Console.WriteLine(result);
            return result;

        }

        public (int, int, int) Task_4_C(int[] array)
        {
            int maxItem = array.Max(x => x);
            int minItem = array.Min(x => x);
            int sumOfItems = array.Sum();
            var result = (maxItem, minItem, sumOfItems);
            return result;
        }

        public void Task_5(int[] array)
        {
            try
            {
                int n = array.Length;
                for (int k = 0; k < n; k++)
                {
                    array[k] = array[k] + 5;
                    Console.WriteLine(array[k]);

                }
            }
            catch
            {
                throw new OverflowException();
            }

        }

        public void Task_6(int[] array, SortDirection direction)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + 1);
            }

            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public double Task_7(Func<double, double> func, double x1, double x2, double e, double result = 0)
        {
            throw new NotImplementedException();
        }
    }
}
