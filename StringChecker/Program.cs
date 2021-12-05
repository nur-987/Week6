using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a string to check");
            string input = Console.ReadLine();

            Program p = new Program();
            p.Checker(input);

            Console.ReadLine();
        }

        public bool Checker(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            string str1 = input.Substring(0, input.Length / 2).ToLower();
            string str2 = input.Substring(input.Length / 2).ToLower();

            string vowels = "aeiou";
            Dictionary<char, int> counter = new Dictionary<char, int>();

            foreach (char c in str1)
            {
                if (vowels.Contains(c))
                {
                    if (counter.ContainsKey(c))
                    {
                        counter[c] += 1;
                    }
                    else
                    {
                        counter[c] = 1;
                    }
                }
            }

            foreach (char c in str2)
            {
                if (counter.ContainsKey(c))
                {
                    counter[c] -= 1;
                }
                else
                {
                    counter[c] = 1;
                }
            }

            foreach (KeyValuePair<char, int> keyValuePair in counter)
            {
                if (keyValuePair.Value != 0)
                {
                    return false;
                }

            }
            return true;

            #region
            //bool status = true;
            //foreach (KeyValuePair<char, int> keyValuePair in counter)
            //{
            //    if (keyValuePair.Value != 0)
            //    {
            //        status = false;
            //        break;
            //    }

            //}

            //if (status)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            #endregion

        }
    }
}
