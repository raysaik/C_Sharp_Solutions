using System;
using System.Collections.Generic;

namespace RobertTDD
{
    internal class MyLinkedList
    {

        public Node HeadNode; 
        private Node LastNode; 

        internal int GetElementCount()
        {
            int elementCount = 0;
            var parsingNode = HeadNode;
            while (parsingNode != null)
            {
                LastNode = parsingNode;
                parsingNode = parsingNode.next;
                elementCount++;
            }
            return elementCount;
        }

        internal void AddNode(Node node)
        {
            if (HeadNode == null)
            {
                HeadNode = node;
                return;
            }
            if(HeadNode.next == null)
            {
                HeadNode.next = node;
                LastNode = node;
                return;
            }
            var parsingNode = HeadNode;
            while(parsingNode != null)
            {
                LastNode = parsingNode;
                parsingNode = parsingNode.next;
            }
            LastNode.next = node;
        }

        internal Node GetElementAtIndex(int v)
        {
            int counter = 0;
            var newNode = HeadNode;
            while(newNode !=null)
            {

                if (counter == v)
                    return newNode;
                newNode = newNode.next;
                counter++;
            }
            throw new Exception("No Element Found at given index");
            
        }

        internal void DeleteElementAtIndex(int index)
        {
            int counter = 0;
            var newNode = HeadNode;
            Node lastNode = null;
            while (newNode != null)
            {
                if(counter == index)
                {
                    lastNode.next = newNode.next;
                    return;
                }
                lastNode = newNode;
                newNode = newNode.next;
                
                counter++;
            }
        }

        internal void AddNodeInBulk(params Node[] Nodes)
        {
            foreach(Node node in Nodes)
            {
                AddNode(node);
            }
        }
    }
}