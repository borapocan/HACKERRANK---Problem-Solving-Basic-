using System.Collections.Generic;
using System;


namespace LongestSubarray
{
    class Program
    {
        static int longestSubarray(int[] arr, int n, int k)
        {
            int i, j, Max = 1;
      
            HashSet<int> s = new HashSet<int>();

            for (i = 0; i < n - 1; i++)
            {

                s.Add(arr[i]);

                for (j = i + 1; j < n; j++)
                {

                    if (Math.Abs(arr[i] - arr[j]) == 0 || Math.Abs(arr[i] - arr[j]) == k)
                    {

                        if (!s.Contains(arr[j]))
                        {

                            if (s.Count == 2)

                                break;

                            else

                                s.Add(arr[j]);
                        }
                    }

                    else

                        break;
                }
                if (s.Count == 2)
                {

                    Max = Math.Max(Max, j - i);

                    s.Clear();
                }
                else

                    s.Clear();
            }

            return Max;
        }

        public static void Main(String[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            int N = arr.Length;

            int K = 1;

            int length = longestSubarray(arr, N, K);

            if (length == 1)

                Console.Write(-1);

            else

                Console.Write(length);
        }

    }

}

