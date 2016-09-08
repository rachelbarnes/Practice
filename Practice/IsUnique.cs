using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Practice
{
    [TestFixture]
    public class IsUniqueClass
    {
        /*determine if all the letters in a string are unique
        
        I have 2 methods here: 
            1. use a dictionary to store keys for each new character and aggregating the number of times it is in the string by a counter as the value
            2. put all the chars in a list and determine if a char is a duplciate list element
        */ 

        public bool IsUniqueDictionary(string AmIUnique)
        {
            var dict = new Dictionary<char, int>();
            foreach (var ch in AmIUnique)
           { 
                var count = 0;
                if (dict.Keys.Contains(ch))
                    dict[ch] = count++;
                if (!dict.Keys.Contains(ch))
                    dict.Add(ch, count++);
                if (count > 1)
                    return false;
            }
            return true;
        }
        public bool IsUniqueList(string AmIUnique)
        {
            var list = new List<char>();
            foreach (var ch in AmIUnique)
            {
                if (list.Contains(ch))
                    return false;
                if (!list.Contains(ch))
                    list.Add(ch);
            }
            return true;
        }

        //tests 
        public class IsUniqueTests
        {
            //testing the first method
            [Test]
            public void IsUnique1()
            {
                var myClass = new IsUniqueClass();
                var expected = true;
                var actual = myClass.IsUniqueDictionary("Another");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void IsUnique2()
            {
                var myClass = new IsUniqueClass();
                var expected = false;
                var actual = myClass.IsUniqueDictionary("Extravagant");
                Assert.AreEqual(expected, actual);
            }
            //testing the second method
            [Test]
            public void IsUnique3()
            {
                var myClass = new IsUniqueClass();
                var expected = true;
                var actual = myClass.IsUniqueList("Share");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void IsUnique4()
            {
                var myClass = new IsUniqueClass();
                var expected = false;
                var actual = myClass.IsUniqueList("Kitty");
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
