using System;
using System.Collections.Generic;

namespace RobertTDD
{
    internal class CustomLinkedList
    {
        private int count;

        public int Value { get; private set; }
        public CustomLinkedList NextAddress { get; private set; }

        public CustomLinkedList()
        {
        }

        internal int GetCount()
        {
            return count;
        }

        internal void AddElement(int v)
        {

            this.Value = v;
            if (count == 0)
            {
                this.NextAddress = null;
            }
            count++;
        }

        internal CustomLinkedList GetNextAddress(int v)
        {
            return null;
        }
    }
}