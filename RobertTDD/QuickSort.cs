using System;
using System.Collections.Generic;

namespace RobertTDD
{
    internal class QuickSort
    {

        int lowPivotIndex = 0;
        int highPivotIndex = 0;
        private int[] unsortedElements;
        private int pivotIndex;

        internal int GetPivot()
        {
            return pivotIndex;
        }

        internal void SetPivot(int v)
        {
            pivotIndex = v;
        }

        internal void setElementstoSort(int[] elements)
        {
            unsortedElements = elements;
        }

        internal IEnumerable<int> getElementstoSort()
        {
            return unsortedElements;
        }
        //5,4,3,2,1
        internal IEnumerable<int> Sort(int low, int high, int pivotIndex)
        {
            int i = low-1;
            if (low < high)
            {
                for (int j = low; j < high; j++)
                {
                    if (unsortedElements[j] < unsortedElements[pivotIndex])
                    {
                        i++;
                        swap(i, j);
                    }
                    if (j == pivotIndex)
                    {
                        i++;
                        swap(i, pivotIndex);
                    }
                }
                if (low == 0) lowPivotIndex = i-1;
                if (high == unsortedElements.Length)  highPivotIndex = i+1;
                Sort(highPivotIndex, unsortedElements.Length, unsortedElements.Length - 1); //right sort
                Sort(0, lowPivotIndex+1, lowPivotIndex);
            }
                
            return unsortedElements;
        }



        private void swap(int i, int j)
        {
            var temp = unsortedElements[i];
            unsortedElements[i] = unsortedElements[j];
            unsortedElements[j] = temp;
        }
    }
}