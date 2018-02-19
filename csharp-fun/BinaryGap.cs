using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fun
{
    public static class BinaryGap
    {

        //  A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.
        // For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps.

        // Write a function:

        // class Solution { public int solution(int N); }

        // that, given a positive integer N, returns the length of its longest binary gap.The function should return 0 if N doesn't contain a binary gap.

        // For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5.

        // Assume that:

        // N is an integer within the range[1..2, 147, 483, 647].

        // Complexity:
        // expected worst-case time complexity is O(log(N));
        // expected worst-case space complexity is O(1).

        public static void Run()
        {
            List<int> ec = new List<int>();
            //int[] a = new int[] { -1, 1, 3, 6, 4, 1, 2 };

            ec.Add(1);
            ec.Add(0);
            ec.Add(2);
            ec.Add(1041);
            ec.Add(15);
            ec.Add(612);
            ec.Add(1925);
            ec.Add(8689);
            ec.Add(2);

            foreach (var item in ec)
            {
                int binaryGap = solution(item);
                Console.WriteLine("Binary gap of " + item.ToString() + " is " + binaryGap);

            }


            Console.Read();

        }

        public static int solution(int N)
        {

            var binaryValue = Convert.ToString(N, 2);

            //Console.Write(" Binario string " + binaryValue + " - ");

            List<int> max = new List<int>();

            var barray = binaryValue.ToCharArray();

            List<int> oneIndexes = new List<int>();
            findOnes(barray, -1, oneIndexes);

            List<int> maxGap = new List<int>();

            for (int i = 0; i < oneIndexes.Count - 1; i++)
            {
                var ngap = oneIndexes[i + 1] - (oneIndexes[i] + 1);
                maxGap.Add(ngap);
            }

            try
            {
                return maxGap.Max();
            }
            catch (Exception)
            {

                return 0;
            }
        }

        static void findOnes(char[] binary, int index, List<int> oneIndexes)
        {
            int f = Array.FindIndex(binary, index + 1, c => c.Equals('1'));
            if (f == -1)
            {
                return;
            }
            oneIndexes.Add(f);

            findOnes(binary, f, oneIndexes);
        }
    }
}
