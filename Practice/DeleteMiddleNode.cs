using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    class DeleteMiddleNode
    {
        /*
         Delete the middle node, which can be qualified as any node besides the first and the last
         example input: delete c from linked list: a-b-c-d-e
         example output: a-b-d-e
        */
        public LinkedList<char> RemoveNode(LinkedList<char> linked, char value)
        {
            var newLinkedList = new LinkedList<char>();
            if (value == linked.First() || value == linked.Last())
                return newLinkedList;
            //while returning an empty list isn't preferable, it's what I have to make sure i dont delete the first or the last value                    
            foreach (var node in linked)
            {
                if (node != value)
                    newLinkedList.AddLast(node);
            }
            return newLinkedList;
        }
    }
    [TestFixture]
    class DeleteMiddleNodeTest
    {
        [Test]
        public void TestDeleteMiddleNode()
        {
            var remove = new DeleteMiddleNode();
            var original = new LinkedList<char>();
            original.AddLast('a');
            original.AddLast('b');
            original.AddLast('c');
            original.AddLast('d');
            original.AddLast('e');
            var removedNode = new LinkedList<char>();
            removedNode.AddLast('a');
            removedNode.AddLast('b');
            removedNode.AddLast('d');
            removedNode.AddLast('e');
            var expected = removedNode;
            var actual = remove.RemoveNode(original, 'c');
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDeleteFirstNode()
        {
            var remove = new DeleteMiddleNode();
            var original = new LinkedList<char>();
            original.AddLast('a');
            original.AddLast('b');
            original.AddLast('c');
            original.AddLast('d');
            original.AddLast('e');
            var removedNode = new LinkedList<char>();
            var expected = removedNode;
            var actual = remove.RemoveNode(original, 'a');
            Assert.AreEqual(expected, actual);
        }
    }
}
