using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace RobertTDD
{
    public class QuickSortTest
    {
        QuickSort quickSort = new QuickSort();


        //[Fact]
        //public void setAndGetPivot()
        //{
        //    quickSort.SetPivot(10);
        //    Assert.Equal(10, quickSort.GetPivot());
        //}

        //[Fact]
        //public void getElementsToSort()
        //{
        //    int[] elements = new int[100];
        //    quickSort.setElementstoSort(elements);
        //    Assert.Equal(elements, quickSort.getElementstoSort());
        //}

        //[Fact]
        //public void sortOneElement()
        //{
        //    int[] elements = new int[1] { 11 };
        //    int[] sortedElements = new int[1] { 11 };
        //    quickSort.setElementstoSort(elements);
        //    Assert.Equal(sortedElements, quickSort.Sort());
        //}

        //[Fact]
        //public void sortTwoElements()
        //{
        //    int[] elements = new int[] { 11, 9 };
        //    int[] sortedElements = new int[] { 9, 11 };
        //    quickSort.setElementstoSort(elements);
        //    Assert.Equal(sortedElements, quickSort.Sort());
        //}

        //[Fact]
        //public void sortThreeElements()
        //{
        //    int[] elements = new int[] { 11, 9, 7 };
        //    int[] sortedElements = new int[] { 7, 9, 11 };
        //    quickSort.setElementstoSort(elements);
        //    Assert.Equal(sortedElements, quickSort.Sort());
        //}

        [Fact]
        public void sortThreeElements_twoAlreadySorted()
        {
            int[] elements = new int[] { 11, 13, 7 };
            quickSort.setElementstoSort(elements);
            int[] sortedElements = elements;
            Array.Sort(sortedElements);
            Assert.Equal(sortedElements, quickSort.Sort(0, elements.Length, elements.Length -1));
        }

        [Fact]
        public void sortTenElements_multiSorted()
        {
            int[] elements = new int[] { 10,80,30,90,40,50,70 };
            quickSort.setElementstoSort(elements);
            int[] sortedElements = elements;
            Array.Sort(sortedElements);
            Assert.Equal(sortedElements, quickSort.Sort(0,7,6));
        }

        [Fact]
        public void sortTenElements_multiNonSorted()
        {
            int[] elements = new int[] { 100, 80, 30, 19, 40, 5, 70 };
            quickSort.setElementstoSort(elements);
            int[] sortedElements = elements;
            //Array.Sort(sortedElements);
            var sorto = quickSort.Sort(0, 7, 6);
            Assert.Equal(sortedElements, sorto);
        }
    }
}
