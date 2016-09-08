using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    [TestFixture]
    class StringPermutationClass
    {
        /*Given 2 strings to compare, determine if the second is a permutation of the other
        
            I am assuming that the first string is longer or the same length as the second string is being tested as a permutation. 
            I also have all my tests in lowercase letters; if I needed to check uppercase and lowercase, then I would leave this as is. 
                If case, didn't matter, I would make the entire string either .ToUpper() or .ToLower() to even the strings

            I also don't have a catch set up to determine if 
            This is one I want to come back to, as having 2 foreach loops isn't ideal; so i'll be back!
         */
        public bool StringPermutation(string a, string b)
        {
            var list = new List<char>();
            if (b.Length > a.Length)
                return false;
            foreach (var ch in a)
            {
                if (!list.Contains(ch))
                    list.Add(ch);
            }
            foreach (var ch in b)
            {
                if (!list.Contains(ch))
                    return false;
            }
            return true;
        }
    }
    class StringPermutationTests
    {
        [Test]
        public void CheckPerm()
        {
            var checkStrings = new StringPermutationClass();
            var expected = true;
            var actual = checkStrings.StringPermutation("kitty", "kyt");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckPerm2()
        {
            var checkStrings = new StringPermutationClass();
            var expected = false;
            var actual = checkStrings.StringPermutation("Cube", "kyt");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckPerm3()
        {
            var checkStrings = new StringPermutationClass();
            var expected = false;
            var actual = checkStrings.StringPermutation("LegnthTest", "ThisStringShouldImmediatelyReturnFalse");
            Assert.AreEqual(expected, actual);
        }
    }
}