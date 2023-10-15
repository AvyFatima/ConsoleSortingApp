using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
    class QuickSort
    {
        public void MainQuickSort(int[] arr)
        {

            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Quick Sort Array : {0}", string.Join(", ", arr));
            
        }

        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        public int Partition(int[] arr, int low, int high)
        {
            int i = low - 1;

            int pi = arr[high];
            for (int j=low;j<=high-1;j++) {
                if (arr[j] < pi)
                {
                    i++;
                    swap(arr,i,j);
                }
            }
            swap(arr, i+1, high);

            return i+1;

        }


        static int[] swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return arr;
        }
     }
}
