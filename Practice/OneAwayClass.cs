using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    [TestFixture]
    class OneAwayClass
    {
        /*
         test to see if b is only one letter manipulation away from a either by replacement, amendment or deletion
        
            exmaple 1: "test" -> "rest" == true
            example 2: "ride" -> "pine" == false

            my example here counts on b not being a longer string than a, which does not qualify the condition of amending to a, such as a plural

            the manipulations in my code also do not take into account any capitalization of the characters in my strings
        */
        public bool OneAway(string a, string b)
        {
            var list = new List<char>();
            var countSimilarLetters = 0;
            foreach (var Ach in a)
                list.Add(Ach);
            foreach (var Bch in b)
            {
                if (list.Contains(Bch))
                    countSimilarLetters += 1;
            }
            if (Math.Abs(countSimilarLetters - a.Length) == 1 || (countSimilarLetters - a.Length == 0))
                return true;
                //because of the absolute value for the first part of thei conditinoal, it does work on amended strings (where b is longer than a)
            else return false;
        }
    }
    class OneAwayTests
    {
        [Test]
        public void OneAway()
        {
            var oneaway = new OneAwayClass();
            var expected = true;
            var actual = oneaway.OneAway("test", "rest");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneAway2()
        {
            var oneaway = new OneAwayClass();
            var expected = false;
            var actual = oneaway.OneAway("ride", "pine");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneAway3()
        {
            var oneaway = new OneAwayClass();
            var expected = false;
            var actual = oneaway.OneAway("ride", "pine");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OneAwayAmendment()
        {
            var oneaway = new OneAwayClass();
            var expected = true;
            var actual = oneaway.OneAway("Amendment", "Amendments");
            Assert.AreEqual(expected, actual);
        }
    }
}
