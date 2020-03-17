using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++) {
                unsorted.Add(random.Next(0, 100));
            }
            WriteLine("Original array elements: {0}", string.Join(", ", unsorted));

            List<int> sorted = MergeSort(unsorted);

            WriteLine("Sorted array elements: {0}", string.Join(", ", sorted));
        }

        static int recursiveCnt = 0;
        private static List<int> MergeSort(List<int> unsorted)
        {
            recursiveCnt++;
            WriteLine("Recursive Cnt: " + recursiveCnt);
            if (unsorted.Count <= 1)
                return unsorted;
            int middle = unsorted.Count / 2;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < middle; i++)
                left.Add(unsorted[i]);
            for (int i = middle; i < unsorted.Count; i++)
                right.Add(unsorted[i]);
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            return result;
        }
    }
}
