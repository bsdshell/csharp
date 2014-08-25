using System;
using System.Collections.Generic;
namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 7, 4, 6, 8, 10, 2, 1};
            int lo = 0;
            int hi = myArray.Length - 1;

            QuickSort(myArray, lo, hi);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("[{0}]={1}", i, myArray[i]);
            }
            Console.ReadLine();
        }

        static void QuickSort(int[] array, int lo, int hi)
        {
            if (lo < hi)
            {
                //Partition elements < pivot < elements
                //[lo - (pivot-1)] [pivot] [(pivot + 1)-hi]
                int indexPivot = Partition(array, lo, hi);
                //Elements < pivot
                QuickSort(array, lo, indexPivot - 1);
                //Elements > pivot
                QuickSort(array, indexPivot + 1, hi);
            }
        }

        private static int Partition(int[] array, int lo, int hi)
        {
            int indexPivot = 0;
            if (array != null)
            {
                if (lo < hi)
                {
                    List<int> left = new List<int>();
                    List<int> right = new List<int>();
                    int pivot = array[lo];
                    for (int i = lo + 1; i < hi + 1; i++)
                    {
                        if (array[i] < pivot)
                        {
                            left.Add(array[i]);
                        }
                        else if (array[i] > pivot)
                        {
                            right.Add(array[i]);
                        }
                    }

                    indexPivot = lo + left.Count;
                    int index = lo;
                    //Copy elements < pivot
                    foreach (int element in left)
                    {
                        array[index] = element;
                        index++;
                    }

                    //Copy element == pivot
                    array[index] = pivot;
                    index++;

                    //Copy elements > pivot
                    foreach (int element in right)
                    {
                        array[index] = element;
                        index++;
                    }
                }
            }
            return indexPivot;
        }
    }
}
