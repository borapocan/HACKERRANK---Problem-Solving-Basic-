using System.Collections.Generic;
using System.Linq;
using System;

namespace RoadRepair
{
    class Program
    {
        static long GetMinCost(List<int> crew, List<int> job)
        {
            Array.Sort(crew.ToArray());

            Array.Sort(job.ToArray());

            long ans = 0;

            for (int i = 0; i < job.ToArray().Length; i++)
            {
                ans += Math.Abs(job[i] - crew[i]);
            }

            return ans;

        }


        static void Main(string[] args)
        {

            int[] crewArr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            List<int> crewList = crewArr.ToList();

            int[] jobArr = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt32(x));

            List<int> jobList = jobArr.ToList();

            long res = GetMinCost(crewList, jobList);

            Console.WriteLine(res);

        }

    }

}
