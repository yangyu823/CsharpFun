using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Search
{

    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            if (sortedArray[0] >= lessThan) return 0;

            int lengthOfArray = sortedArray.Length;
            if (lengthOfArray == 0) return 0;
            if (sortedArray[lengthOfArray - 1] < lessThan) return lengthOfArray;

            int index = Array.BinarySearch(sortedArray, lessThan);
            if (index < 0)
                return ~index;

            return index;


            throw new NotImplementedException("Waiting to be implemented.");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));

            Console.ReadKey();
        }
    }
}
