using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RobertTDD
{
    public class BubbleSortTest
    {

        BubbleSort bubbleSort = new BubbleSort();



        [Fact]
        public void getBubbleSort()
        {
            Assert.True(bubbleSort.GetType() == typeof(BubbleSort));
        }

        [Fact]
        public void sortOneElement()
        {
            bubbleSort.setElements(new int[] { 1 });
            int [] sortedElements = bubbleSort.sortElements();
            Assert.Equal(new int[] { 1 }, sortedElements);
        }

        [Fact]
        public void sortTwoElements_withBubble()
        {
            var elements = new int[] { 3, 2 };
            bubbleSort.setElements(elements);
            Assert.Equal(new int[] { 2,3 }, bubbleSort.sortElements());
        }     

        [Fact]
        public void sortTwoElements_AlreadySorted()
        {
            var elements = new int[] { 2, 3 };
            bubbleSort.setElements(elements);
            Assert.Equal(new int[] { 2, 3 }, bubbleSort.sortElements());
        }

        [Fact]
        public void sortThreeElements()
        {
            var elements = new int[] { 11, 5, 17 };
            bubbleSort.setElements(elements);
            Assert.Equal(new int[] { 5, 11, 17 }, bubbleSort.sortElements());
        }

        [Fact]
        public void sortThreeElements_reverseSorted()
        {
            var elements = new int[] { 17, 11, 5 };
            bubbleSort.setElements(elements);
            Assert.Equal(new int[] { 5, 11, 17 }, bubbleSort.sortElements());
        }

        //[Fact]
        //public void sortThreeElements_AlreadySorted()
        //{
        //    var elements = new int[] { 11, 15, 17 };
        //    ActAndAssertSort(elements);
        //}

        //[Fact]
        //public void sortMultipleElemts()
        //{
        //    var elements = new int[] { 12, 6546, 2, 767, 21, 3, 43, 66, 12 };
        //    ActAndAssertSort(elements);
        //}

    }
}
