using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort Array
            int[] arr = new int[] { 12, 4, 10, 6, 2, 5 };
            Console.WriteLine("Unsorted Array : {0}", string.Join(", ", arr));
            QuickSort qs = new QuickSort();
            qs.MainQuickSort(arr);

            arr = new int[] { 3, 1, 7, 8, 9, 4 };
            Console.WriteLine("Unsorted Array : {0}", string.Join(", ", arr));
            MergeSort ms = new MergeSort();
            ms.MainMergeSort(arr);


            arr = new int[] { 4, 5, 7, 1, 9, 6 };
            Console.WriteLine("Unsorted Array : {0}", string.Join(", ", arr));
            BinaryST bst = new BinaryST();
            bst.MainBST(arr);

            OtherString os = new OtherString();
            os.MainString();

            Console.ReadLine();

        }
        
    }
}
