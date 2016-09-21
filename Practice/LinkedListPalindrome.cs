using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
namespace Practice
{
    class LinkedListPalindrome
    {
        /*
         check if a linked list is an algorithm
        */
        public bool IsPalindrome(LinkedList<char> linked)
        {
            var dict = new Dictionary<char, int>();
            var count = 0; 
            foreach (var node in linked)
            {
                if (dict.Keys.Contains(node))
                    dict[node] = dict[node] + 1;
                if (!dict.Keys.Contains(node))
                    dict.Add(node, 1); 
            }
            foreach (KeyValuePair<char, int> pair in dict)
            {
                if (pair.Value % 2 != 0)
                    count++; 
            }
            if (count > 1)
                return false;
            return true; 
        }
    }
    [TestFixture]
    class LinkedListPalindromeTests
    {
        [Test]
        public void TruePalindrome()
        {
            var pal = new LinkedListPalindrome();
            var Palindrome = new LinkedList<char>();
            Palindrome.AddLast('r'); 
            Palindrome.AddLast('a'); 
            Palindrome.AddLast('c'); 
            Palindrome.AddLast('e'); 
            Palindrome.AddLast('c'); 
            Palindrome.AddLast('a'); 
            Palindrome.AddLast('r');
            var expected = true;
            var actual = pal.IsPalindrome(Palindrome);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void FalsePalindrome()
        {
            var pal = new LinkedListPalindrome();
            var NotAPalindrome = new LinkedList<char>();
            NotAPalindrome.AddLast('a'); 
            NotAPalindrome.AddLast('b'); 
            NotAPalindrome.AddLast('c'); 
            NotAPalindrome.AddLast('d'); 
            NotAPalindrome.AddLast('e'); 
            NotAPalindrome.AddLast('f'); 
            NotAPalindrome.AddLast('g'); 
            NotAPalindrome.AddLast('h');
            var expected = false;
            var actual = pal.IsPalindrome(NotAPalindrome);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TrueEvenPalindrome()
        {
            var pal = new LinkedListPalindrome();
            var Palindrome = new LinkedList<char>();
            Palindrome.AddLast('t'); 
            Palindrome.AddLast('a'); 
            Palindrome.AddLast('c'); 
            Palindrome.AddLast('o'); 
            Palindrome.AddLast('o'); 
            Palindrome.AddLast('c'); 
            Palindrome.AddLast('a'); 
            Palindrome.AddLast('t');
            var expected = true; 
            var actual = pal.IsPalindrome(Palindrome);
            Assert.AreEqual(expected, actual); 
        }
    }
}
