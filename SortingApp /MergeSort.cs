using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
    class MergeSort
    {

        public void MainMergeSort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Merge Sort Array : {0}", string.Join(", ", arr)); 
        }
        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right-left) / 2;
                Sort(arr,left,mid);
                Sort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }

        }
        
        public void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[left+i];
            }

            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[mid+1+j];
            }

            int k = left;
            i = 0; j = 0;
            while (i < n1 && j < n2)
            {
                if (L[i]<=R[j]) {
                    arr[k] = L[i];
                    i++;
                } else {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++; k++;
            }

        }
        
    }
}
