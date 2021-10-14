using System;
using System.Collections.Generic;

namespace s1.SapXepNoiBot
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            List<int> arr = new List<int>();
            arr.Add(5);
            arr.Add(2);
            arr.Add(8);
            arr.Add(1);
            int a;

            for (int i = 0; i <= arr.Count - 2; i++)
            {
                for (int j = 0; j <= arr.Count - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        a = arr[j + 1];
                        arr[j + 1] = arr[i];
                        arr[i] = a;
                    }
                }
            }

            foreach (int aa in arr)
            {
                Console.WriteLine(aa);
            }
            
        }
    }
}