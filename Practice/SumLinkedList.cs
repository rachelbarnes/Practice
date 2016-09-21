using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    /*
        two numbers represented by a linkedlist, they're numbers in reverse order
        write a function that adds the two numbers and returns the sum as a linkedlist in reverse order
        
        input (7-1-6) + (5-9-2) => 617 + 295 (which == 912)
        output: 2-1-9 => aka, 912
    */
    class SumLinkedList
    {
        //this method only takes 2 linkedlist numbers
        //this is all well except for the aInt and bInt aren't reversed... i think I'll have to do some manual reversing. 
            //I figure an interviewer would expect a simple string reversal manually rather than a predefined function
        public LinkedList<int> Sum(LinkedList<int> a, LinkedList<int> b)
        {
            var aInt = "";
            var bInt = "";
            var result = new LinkedList<int>();
            foreach (var node in a)
                aInt = node + aInt; 
            foreach (var node in b)
                bInt = node + bInt;
            var sum = int.Parse(aInt) + int.Parse(bInt);
            foreach (var element in sum.ToString())
                result.AddFirst((int)element); //i'm having a problem where i'm getting the ascii equivalent as opposed to the actual int char. 
            return result;
        }
    }
    /*
     Questions for Steve: 
        - I've been looking into this for quite a bit, and 


    */ 



    [TestFixture]
    class SumLinkedListTest
    {
        [Test]
        public void TestSum()
        {
            var sum = new SumLinkedList(); //6357 + 28564 = 34921 
            var a = new LinkedList<int>();
            a.AddLast(7);
            a.AddLast(5);
            a.AddLast(3);
            a.AddLast(6);
            var b = new LinkedList<int>();
            b.AddLast(4);
            b.AddLast(6);
            b.AddLast(5);
            b.AddLast(8);
            b.AddLast(2);
            var result = new LinkedList<int>();
            result.AddLast(1);
            result.AddLast(2);
            result.AddLast(9);
            result.AddLast(4);
            result.AddLast(3);
            var expected = result;
            var actual = sum.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSimplerSum()
        {
            var sum = new SumLinkedList(); //5+63 = 68
            var a = new LinkedList<int>();
            a.AddLast(5);
            var b = new LinkedList<int>();
            b.AddLast(3);
            b.AddLast(6);
            var result = new LinkedList<int>();
            result.AddLast(8);
            result.AddLast(6);
            var expected = result;
            var actual = sum.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
