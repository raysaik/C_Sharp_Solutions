using System;
using System.Collections.Generic;

namespace RobertTDD
{
    internal class QuickSort2
    {
        int[] elementsToSort = new int[] { };
        public QuickSort2()
        {
        }

        internal void SetElementsToSort(int[] unsorted)
        {
            elementsToSort = unsorted;
        }

        internal IEnumerable<int> Sort()
        {
            var length = elementsToSort.Length;
            QuickSort(0, length -1, length -1);
            return elementsToSort;
        }

        internal void QuickSort(int low, int high, int pivot)
        {
            int i = -1;
            for(int k = low; k < high; k++)
            {
                if(elementsToSort[k] <= elementsToSort[pivot])
                {
                    i++;
                    swap(i, k);
                }
            }



        }

        private void swap(int f, int g)
        {
            int temp = elementsToSort[f];
            elementsToSort[f] = elementsToSort[g];
            elementsToSort[g] = temp;
        }
    }
}