using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
namespace Practice
{
    class LinkedListNotes
    {
        /*
         linked lists:  
            difference between linked lists and array lists
                list<t> does not contain links to the previous or next object, while linkedList<t> is a list of objects that is more efficient accessing data 
                    if you're only concerned with going forwards to backwards (hence, the linked part of this)
                        linkedlists can be singly and doubly linked - it can go forwards and backwards

        notes from dotnetperls on linked list: 
            easiest way to loop through and examine all the contents of a list is the foreach loop
        */

        //    public void CreateLinkedList()
        //    {
        //        //initializing and creating a linked list:              
        //        LinkedList<string> myLinkedList = new LinkedList<string>();
        //        myLinkedList.AddLast("Then");
        //        myLinkedList.AddLast("add");
        //        myLinkedList.AddLast("another");
        //        myLinkedList.AddFirst("This is the first item in the list");

        //        foreach (var node in myLinkedList)
        //            Console.WriteLine(node);
        //    }

        //    public void FindANodeInLinkedList()
        //    {
        //        LinkedList<string> linked = new LinkedList<string>();
        //        linked.AddLast("one");
        //        linked.AddLast("two");
        //        linked.AddLast("three");

        //        LinkedListNode<string> node = linked.Find("one");
        //        linked.AddBefore(node, "half");
        //        linked.AddAfter(node, "one and a half");

        //        foreach (var item in linked)
        //            Console.WriteLine(item);

        //        /*
        //        this adds values to the end of the list. 
        //        it locates a specific value (or a node) in the list
        //            with our AddAfter method adds the value afterwards. in this, we would get - 
        //                "half", "one", "one and a half", "two", "three"

        //        The biggest time complexity saver comes from bien gable to insert and remove elements (nodes) 
        //            quickly
        //        other things you can do: remove
        //        */
        //    }
        //}
        //public class Node
        ////the following are some examples from the book: 
        ////creating a linked list: 
        //{
        //    Node next = null;
        //    int data;

        //    public Node(int d)
        //    {
        //        data = d;
        //    }
        //    void appendToTail(int d)
        //    {
        //        Node end = new Node(d);
        //        Node n = this; 
        //        while (n.next != null)
        //        {
        //            n = n.next; 
        //        }
        //        n.next = end;
        //    }
        //    //i'm still have trouble with the constructors and stuff... creating objects...
        //}

    }

    public class LinkedListStuff
    {
        public LinkedList<char> RemoveDuplicates(LinkedList<char> linked)
        {
            LinkedList<char> linked = new LinkedList<char>();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var node in linked)
            {
                if (dict.Contains(node))
                    dict[node] = dict[node] + 1;
                if (!dict.Contains(node))
                    dict.Add(node, 1);
            }
            linked.AddLast(dict.Keys);
        }
    }
    public class LinkedListTests
        {

    }
}

