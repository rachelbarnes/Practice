using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
namespace Practice
{
    class ReverseString
    {
        //simple, just reverse a string without calling the Reverse() method
            //seeing that I'm trying to do this with linkedlists, I don't want to use indexing with a for loop
        public string ReverseReverse(string a)
        {
            var reverseA = ""; 
            foreach (var ch in a)
                reverseA = ch + reverseA;
                    //this is "pushing" the reverseA to further indexes, while putting the current ch in the 0 index position
            return reverseA; 
        }
    }
    [TestFixture]
    class ReverseStringTest
    {
        [Test]
        public void TestReverse()
        {
            var rev = new ReverseString();
            var expected = "gnihtemos";
            var actual = rev.ReverseReverse("something");
            Assert.AreEqual(expected, actual); 
        }
    }
}
