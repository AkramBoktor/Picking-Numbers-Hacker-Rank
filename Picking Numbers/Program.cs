using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picking_Numbers
{
    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     *
     *6
1 2 2 3 1 2
        solution 5
        -------------------------------------------
        6
4 6 5 3 3 1
        solution 3

        */
    class Program
    {  

        public static int pickingNumbers(List<int> a)
        {
              a.Sort();
            int count;
            int subarray = 0;
            for (int i = 0; i < a.Count; i++)
            {
                count = 0;
                for (int j = i; j < a.Count; j++)
                {
                    if (Math.Abs(a[i] - a[j]) <= 1)
                    {
                        count++;
                    }
                }
                if (count > subarray)
                {
                    subarray = count;
                }
            }

            return subarray;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Program.pickingNumbers(a);

            Console.WriteLine(result);

        }
    }
}
