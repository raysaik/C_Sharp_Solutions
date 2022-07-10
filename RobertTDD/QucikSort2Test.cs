using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RobertTDD
{
    public class QucikSort2Test
    {
        QuickSort2 quickSort2 = new QuickSort2();
        [Fact]
        public void SetUnsortedElements()
        {
            int[] unsorted = new int[] { 23, 1, 27, 2, 18 };
            quickSort2.SetElementsToSort(unsorted);
        }

        [Fact]
        public void SortOneElement()
        {
            int[] unsorted = new int[] { 23 };
            int[] sorted = new int[] { 23 };
            quickSort2.SetElementsToSort(unsorted);
            Assert.Equal(sorted,quickSort2.Sort());
        }

        [Fact]
        public void SortTwoElements_AlreadySorted()
        {
            int[] unsorted = new int[] { 3 , 12 };
            int[] sorted = new int[] { 3 , 12 };
            quickSort2.SetElementsToSort(unsorted);
            Assert.Equal(sorted, quickSort2.Sort());
        }
        
        [Fact]
        public void SortTwoElements_ReverseSorted()
        {
            int[] unsorted = new int[] { 13 , 12 };
            int[] sorted = new int[] { 12 , 13 };
            quickSort2.SetElementsToSort(unsorted);
            Assert.Equal(sorted, quickSort2.Sort());
        }

    }
}
