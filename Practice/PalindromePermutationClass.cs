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

        /*I was struggling doing this without what seemed like an infinite amount of nested conditionals...

        this is a brute force solution, on way to a better solution - it has unneeded complciation and unneeded data manipulation (like current place, current key, etc.)
        This does not include spaces, or capitalized vs lowercase chars

        This is not complete, despite it being an attempt at a brute force application
        */
        public bool PalindromePermutation(string AmIAPalindrome)
        {
            var dict = new Dictionary<char, int>();
            var odd = 0;
            for (int i = 0; i < AmIAPalindrome.Length; i++)
            {
                var currentPlace = AmIAPalindrome[i];
                var currentKey = dict[currentPlace];
                if (dict.Keys.Contains(AmIAPalindrome[i]))
                {
                    dict[currentPlace] = dict[currentPlace] + 1;
                    //look at the rest of the string... does it contain the character again? if not, then this is the final value for the key
                    if (AmIAPalindrome.Substring(i + 1) != null)
                    {
                        if (!AmIAPalindrome.Substring(i + 1, (AmIAPalindrome.Length - (i + 1))).Contains(currentPlace))
                            odd += 1;
                    }
                }
                if (!dict.Keys.Contains(currentPlace))
                    dict.Add(currentPlace, 1);
            }
            return true;
        }
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
            var expected = false;
            var actual = pal.PalindromePermutation("aaaa");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void PalinPerm3()
        {
            var pal = new PalindromePermutationClass();
            var expected = false;
            var actual = pal.PalindromePermutation("asdfghfdsa"); //there's a single 'g' and a single 'h', so this should be false 
            Assert.AreEqual(expected, actual); 
        }
    }
}

