using System;

namespace RobertTDD
{
    internal class Stack
    {
        private int elemCount;

        private string[] elem = new string[21];
        public Stack()
        {
        }

        internal int GetElementCount()
        {
            return elemCount;
        }

        internal void Push(string v)
        {
            elem[elemCount] = v;
            elemCount++;
        }

        internal string Pop()
        {
            var popResult = elem[elemCount-1];
            elem[elemCount-1] = null;
            elemCount--;
            return popResult;
        }
    }
}