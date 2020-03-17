using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                arr.Add(random.Next(0, 100));
            WriteLine("Unsorted: {0}", string.Join(", ", arr));
            QuickSort(arr, 0, arr.Count - 1);
            WriteLine("Sorted: {0}", string.Join(", ", arr));

        }

        static int qsCnt = 0;
        private static void QuickSort(List<int> arr, int left, int right)
        {
            WriteLine("QuickSort Count: {0}",++qsCnt);
            if (left < right) {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        private static int Partition(List<int> arr, int left, int right)
        {
            int pivot = arr[left];
            while (true) {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                if (left < right)
                {
                    if (arr[left] == arr[right])
                        return right;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else {
                    return right;
                }
            }
        }
    }
}
