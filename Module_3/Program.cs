using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2 task2 = new Task2();
            task2.GetEvenNumbers(14);
        }

    }
    public class Task1
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// Throw ArgumentException if user input is invalid
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int ParseAndValidateIntegerNumber(string source)
        {
            int num = 0;
            if (!Int32.TryParse(source, out num))
            {
                throw new ArgumentException();
            }
            else return num;
        }

        public int Multiplication(int num1, int num2)
        {

            if (num1 == 0 | num2 == 0)
            {
                return 0;
            }
            else if (num1 < 0 & num2 < 0)
            {
                return num1 * num2;
            }
            else if (num1 < 0)
            {
                return Enumerable.Range(0, num2).Select(n => num1).Aggregate((f, s) => f + s);
            }
            else if (num2 < 0)
            {
                return Enumerable.Range(0, num1).Select(n => num2).Aggregate((f, s) => f + s);
            }
            else return 0;
        }
    }

    public class Task2
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

        public List<int> GetEvenNumbers(int naturalNumber)
        {
            List<int> list = new List<int>();
            
            try
            {

                if (naturalNumber > 0)
                {
                    int i = 1, k = 1;

                    while (true)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                            k++;
                        }
                        else if (naturalNumber % 2 == 1)
                        {
                            throw new ArgumentException();
                        }
                        if (k > naturalNumber)
                        {
                            break;
                        }

                        i++;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }
    }

    public class Task3
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            bool output = int.TryParse(input, out result);
            if (output == true)
                return true;
            else
                return false;
        }

        public string RemoveDigitFromNumber(int source, int digitToRemove)
        {
            int res = 0;
            int pow = 1; 
            while (source != 0)
            {
                var temp = source % 10;
                source /= 10;
                if (temp == digitToRemove) continue;

                res += temp * pow;
                pow *= 10;

            }
            return res.ToString();

        }
    }
}
