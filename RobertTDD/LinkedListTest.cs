using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RobertTDD
{
    public class LinkedListTest
    {
        MyLinkedList myLinkedList = new MyLinkedList();

        [Fact]
        public void EmptyLinkedList_HeadNodeIsNull()
        {
            Assert.Null(myLinkedList.HeadNode);
        }

        [Fact]
        public void AddOneElement_HeadNodeISNotNull()
        {
            var nodeOne = new Node(100);
            myLinkedList.AddNode(nodeOne);
            Assert.NotNull(myLinkedList.HeadNode);
        }

        [Fact]
        public void AddOneElement_ValueMatches()
        {
            var nodeOne = new Node(200);
            myLinkedList.AddNode(nodeOne);
            Assert.Equal(nodeOne.value, myLinkedList.HeadNode.value);
        }

        [Fact]
        public void AddTwoElements_HeadNodeValueIsFirstElementValue()
        {
            var nodeOne = new Node(10);
            var nodeTwo = new Node(20);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            Assert.Equal(nodeOne.value,myLinkedList.HeadNode.value);
        }

        [Fact]
        public void AddTwoElements_HeadNodeNextElementIsSecondElement()
        {
            var nodeOne = new Node(10);
            var nodeTwo = new Node(11);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            Assert.Equal(nodeTwo,myLinkedList.HeadNode.next);
        }
        
        [Fact]
        public void AddTwoElements_GetSecondElementValueFromFirstElement()
        {
            var nodeOne = new Node(20);
            var nodeTwo = new Node(21);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            Assert.Equal(nodeOne,myLinkedList.GetElementAtIndex(0));
            Assert.Equal(nodeTwo,myLinkedList.GetElementAtIndex(1));
        }

        [Fact]
        public void AddTwoElements_TryGetThirdElementValueThrowsException()
        {
            var nodeOne = new Node(20);
            var nodeTwo = new Node(21);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            Assert.Throws<Exception>(()=> myLinkedList.GetElementAtIndex(2));
        }

        [Fact]
        public void AddThreeElements_GetAllElementsValueFromFirstElement()
        {
            var nodeOne = new Node(30);
            var nodeTwo = new Node(31);
            var nodeThree = new Node(32);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            myLinkedList.AddNode(nodeThree);
            Assert.Equal(nodeOne, myLinkedList.HeadNode);
            Assert.Equal(nodeTwo, myLinkedList.HeadNode.next);
            Assert.Equal(nodeThree, myLinkedList.HeadNode.next.next);
        }
        
        [Fact]
        public void AddThreeElements_GetElementCountByTraversing()
        {
            var nodeOne = new Node(30);
            var nodeTwo = new Node(31);
            var nodeThree = new Node(32);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            myLinkedList.AddNode(nodeThree);
            Assert.Equal(3, myLinkedList.GetElementCount());
        }

        [Fact]
        public void AddThreeElementsDeleteone_GetElementCountByTraversing()
        {
            var nodeOne = new Node(30);
            var nodeTwo = new Node(31);
            var nodeThree = new Node(32);
            myLinkedList.AddNode(nodeOne);
            myLinkedList.AddNode(nodeTwo);
            myLinkedList.AddNode(nodeThree);
            myLinkedList.DeleteElementAtIndex(2);
            Assert.Equal(2, myLinkedList.GetElementCount());
        }

        [Fact]
        public void AddMultipleElementsDeleteMultiple_GetElementCountByTraversing()
        {
            var nodeOne = new Node(30);
            var nodeTwo = new Node(31);
            var nodeThree = new Node(32);
            var node4 = new Node(34);
            var node5 = new Node(35);
            var node6 = new Node(36);
            var node7 = new Node(37);
            var node8 = new Node(38);
            var node9 = new Node(39);
            var node10 = new Node(40);
            var node11 = new Node(41);
            var node12 = new Node(42);
            myLinkedList.AddNodeInBulk(nodeOne, nodeTwo, nodeThree, node4, node5, node6, node7, node8, node9, node10, node11, node12);
            myLinkedList.DeleteElementAtIndex(2);
            Assert.Equal(11, myLinkedList.GetElementCount());
        }

        [Fact]
        public void AddMultipleElementsDeleteMultiple_GetElementAtDeletedIndex()
        {
            var nodeOne = new Node(30);
            var nodeTwo = new Node(31);
            var nodeThree = new Node(32);
            var node4 = new Node(34);
            var node5 = new Node(35);
            var node6 = new Node(36);
            var node7 = new Node(37);
            var node8 = new Node(38);
            var node9 = new Node(39);
            var node10 = new Node(40);
            var node11 = new Node(41);
            var node12 = new Node(42);
            myLinkedList.AddNodeInBulk(nodeOne, nodeTwo, nodeThree, node4, node5, node6, node7, node8, node9, node10, node11, node12);
            myLinkedList.DeleteElementAtIndex(2);
            Assert.Equal(node4, myLinkedList.GetElementAtIndex(2));
        }
    }
}
