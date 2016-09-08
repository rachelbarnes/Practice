using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    [TestFixture]
    class PalindromePermutationClass
    {

        /*
        this is a brute force solution, on way to a better solution - it has unneeded complciation and unneeded data manipulation (like current place, current key, etc.)
        This does not include spaces, or capitalized vs lowercase chars

        This is not complete, despite it being an attempt at a brute force application
        */

        public bool PalindromePermutation(string AmIAPalindrome)
        {
            var dict = new Dictionary<char, int>();
            var odd = 0;
            foreach (var ch in AmIAPalindrome)
            {
                if (dict.Keys.Contains(ch))
                    dict[ch] = dict[ch] + 1;
                if (!dict.Keys.Contains(ch))
                    dict.Add(ch, 1);
            }
            foreach (KeyValuePair<char, int> pair in dict)
            {
                if (pair.Value == 1)
                    odd += 1;
            }
            if (odd > 1)
                return false;
            return true;
        }

        class PalindromePermutationTests
        {
            [Test]
            public void PalinPerm()
            {
                var pal = new PalindromePermutationClass();
                var expected = true;
                var actual = pal.PalindromePermutation("racecar");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void PalinPerm2()
            {
                var pal = new PalindromePermutationClass();
                var expected = true;
                var actual = pal.PalindromePermutation("aaaa");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void PalinPerm3()
            {
                var pal = new PalindromePermutationClass();
                var expected = false;
                var actual = pal.PalindromePermutation("qwerty");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void PalinPerm4()
            {
                var pal = new PalindromePermutationClass();
                var expected = false;
                var actual = pal.PalindromePermutation("asdfghfdsa"); //there's a single 'g' and a single 'h', so this should be false 
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

