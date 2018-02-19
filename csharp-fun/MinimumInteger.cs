using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fun
{
    public static class MinimumInteger
    {
        // Write a function:

        //  class Solution { public int solution(int[] A); }

        // that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

        // For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

        // Given A = [1, 2, 3], the function should return 4.

        // Given A = [−1, −3], the function should return 1.

        // Assume that:

        // N is an integer within the range[1..100, 000];
        // each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
        // Complexity:

        // expected worst-case time complexity is O(N);
        // expected worst-case space complexity is O(N), beyond input storage(not counting the storage required for input arguments).

        public static void Run()
        {
            List<int[]> ec = new List<int[]>();
            //int[] a = new int[] { -1, 1, 3, 6, 4, 1, 2 };

            ec.Add(new int[] { -1, 1, 3, 6, 4, 1, 2 });
            ec.Add(new int[] { 1, 2, 3 });
            ec.Add(new int[] { -1, -3 });

            foreach (var item in ec)
            {
                int minInteger = solution(item);
                
                Console.WriteLine("Min int for" + item.ToArray() + " is " + minInteger);

            }

            Console.WriteLine("Press any key to Continue");
            Console.Read();
        }

        static public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            var na = A.OrderBy(c => c).Where(w => w >= 0).Distinct().ToArray();
            if (na.Length == 0) { return 1; }

            for (int i = 1; i < na.Last(); i++)
            {
                var current = na[i - 1];
                if (i != current)
                {
                    return i;
                }
            }
            return na.Last() + 1;

        }
    }
}
