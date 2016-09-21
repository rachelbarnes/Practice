//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework; 
//namespace Practice
//{
//    class RetrieveKToLastOfLinkedListClass
//    {
//        /*
//         Retrieve kth tot he last element of a single linked list: 
//         */
//        public LinkedList<char> RetrieveNodes(LinkedList<char> linked, char retrievalChar)
//        {
//            LinkedList<char> emptyList = new LinkedList<char>(); 
//            LinkedList<char> newList = new LinkedList<char>();
//            //while this isn't in the question or the problem, it should have a catch if the retrievalChar is not in linked
//            if (!linked.Contains(retrievalChar))
//                return newList; //this will be just an empty initialized list; 
//            var countNodesInLinked = linked.Count(); 
//            //i have a feeling this has something to do with a 
//            foreach (var node in linked)
//            {
//                if (node == retrievalChar)
//                {
//                    //interesting... i can add this node, but i have to add the rest of the nodes after this one
//                    newList.AddLast(node); 
                    
//                }
//            }

//        }
//    }
//}
