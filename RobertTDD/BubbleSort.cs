using System;
using System.Collections.Generic;
using System.Linq;

namespace RobertTDD
{
    internal class BubbleSort
    {
        private int[] unsortedElements;

        public BubbleSort()
        {
        }

        internal void setElements(int[] vs)
        {
            unsortedElements = vs;
        }
        //17, 11, 5
        internal int[] sortElements()
        {
            var length = unsortedElements.Length;
            if ( length > 1)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (i != length - 1 && unsortedElements[i] > unsortedElements[i + 1])
                            swap(i, i + 1);
                    }
                }
            }
            return unsortedElements;
        }

        private void swap(int i, int v)
        {
            var temp = unsortedElements[i];
            unsortedElements[i] = unsortedElements[v];
            unsortedElements[v] = temp;
        }
    }
}