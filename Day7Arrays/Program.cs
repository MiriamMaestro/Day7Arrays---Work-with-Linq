using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            string solution = "";
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ')
                .ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            int longi = arr.Count-1;


            for (int i = 0; i < n; i++)
            {
                solution += arr[i] + " ";
            }
            for (int a = n; a <= longi; a++)
            {
                solution += arr[a] + " ";
            }
            Console.Write(solution);


            
        }
    }
}
