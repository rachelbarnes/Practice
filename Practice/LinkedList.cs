using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    class LinkedListClass
    {
        public LinkedList<char> RemoveDuplicates(LinkedList<char> linked)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            LinkedList<char> newLinked = new LinkedList<char>();
            foreach (var node in linked)
            {
                if (dict.Keys.Contains(node))
                    dict[node] = dict[node] + 1;
                if (!dict.Keys.Contains(node))
                    dict.Add(node, 1);
                //why is it saying that this dict doesn't contain a definition for contains? 
                //because I'm asking if the dictionary contains the node... im not asking if the dictionary KEYS contain it
                //to do this with dict.contains(node), i'm asking if the key value pair contains the node alone, so of course it doesn't work
            }
            foreach (KeyValuePair<char, int> pair in dict)
                newLinked.AddLast(pair.Key);

            return newLinked;
        }
    }
    [TestFixture]
    class LinkedListTest
    {
        [Test]
        public void LinkedListTest1()
        {
            var test = new LinkedListClass();
            var MyDuplicatedLinkedList = new LinkedList<char>();
            //I know there's a better way to initialize this... this is just a more brute way of doing this... i tried: 
            //{ 'a', 'b', 'c', 'd', 'd', 'e', 'f', 'g', 'g', 'g', 'h', 'h', 'h', 'h', 'h', 'i', 'i' };
            MyDuplicatedLinkedList.AddLast('a');
            MyDuplicatedLinkedList.AddLast('b');
            MyDuplicatedLinkedList.AddLast('b');
            MyDuplicatedLinkedList.AddLast('b');
            MyDuplicatedLinkedList.AddLast('b');
            MyDuplicatedLinkedList.AddLast('c');
            MyDuplicatedLinkedList.AddLast('c');
            MyDuplicatedLinkedList.AddLast('j');
            MyDuplicatedLinkedList.AddLast('j');
            MyDuplicatedLinkedList.AddLast('k');
            MyDuplicatedLinkedList.AddLast('w');
            MyDuplicatedLinkedList.AddLast('3');
            MyDuplicatedLinkedList.AddLast('3');
            MyDuplicatedLinkedList.AddLast('4');
            MyDuplicatedLinkedList.AddLast('t');
            MyDuplicatedLinkedList.AddLast('v');
            MyDuplicatedLinkedList.AddLast('x');
            MyDuplicatedLinkedList.AddLast('n');
            var RemovedDuplicatesLinkedList = new LinkedList<char>();
            RemovedDuplicatesLinkedList.AddLast('a');
            RemovedDuplicatesLinkedList.AddLast('b');
            RemovedDuplicatesLinkedList.AddLast('c');
            RemovedDuplicatesLinkedList.AddLast('j');
            RemovedDuplicatesLinkedList.AddLast('k');
            RemovedDuplicatesLinkedList.AddLast('w');
            RemovedDuplicatesLinkedList.AddLast('3');
            RemovedDuplicatesLinkedList.AddLast('4');
            RemovedDuplicatesLinkedList.AddLast('t');
            RemovedDuplicatesLinkedList.AddLast('v');
            RemovedDuplicatesLinkedList.AddLast('x');
            RemovedDuplicatesLinkedList.AddLast('n');
            var actual = test.RemoveDuplicates(MyDuplicatedLinkedList);
            Assert.AreEqual(RemovedDuplicatesLinkedList, actual);

        }
    }
}
