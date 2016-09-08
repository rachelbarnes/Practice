using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
namespace Practice
{
    [TestFixture]

    /*
    Make a string with ordinary spaces in a URL form, putting %20 for all the spaces

    I did this one on paper as well as in VS separately... have to be more careful. I made a few small mistakes that 
        messed up my logic becuase I didn't debug this in my head first. Be careful... something like that looks badly, 
        plus it's better practice to know what's going on in the code before just typing away
    */
    class URLifyClass
    {
        public string URLify(string PreURL)
        {
            var splitPreURL = PreURL.Split(' ');
            var CountWords = splitPreURL.Count();
            var URL = "";
            for (int i = 0; i < CountWords; i++)
            {
                if (i < CountWords - 1)
                    URL += splitPreURL[i] + "%20";
                if (i == CountWords - 1) //if the word is the last word in the array resulting from the string split, don't put the replaceSpace string at the end of the string
                    URL += splitPreURL[i]; 
            }
            return URL; 
        }
    }

    class URLifyTests
    {
        [Test]
        public void URL()
        {
            var ify = new URLifyClass();
            var expected = "Ms%20Rachel%20Barnes";
            var actual = ify.URLify("Ms Rachel Barnes");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void URLOneWordTest()
        {
            var ify = new URLifyClass();
            var expected = "Cats"; 
            var actual = ify.URLify("Cats");
            Assert.AreEqual(expected, actual); 
        }
    }

}
