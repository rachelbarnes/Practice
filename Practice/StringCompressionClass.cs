using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Practice
{
    [TestFixture]
    class StringCompressionClass
    {
        /*
         compress the string based on the number of times each char is noted

         uncompressed -> "aaaabbbcccccdd"
         compressed   -> "a4b3c5d2"

         if the compressed string is longer than the uncompressed string, then returned the uncompressed string
         */
        public string Compress(string uncompressed)
        {
            var dict = new Dictionary<char, int>();
            var compressed = "";
            foreach (var ch in uncompressed)
            {
                if (dict.Keys.Contains(ch))
                    dict[ch] = dict[ch] + 1;
                if (!dict.Keys.Contains(ch))
                    dict.Add(ch, 1);
            }
            foreach (var pair in dict)
                compressed += pair.Key.ToString() + pair.Value.ToString();

            if (compressed.Length > uncompressed.Length)
                return uncompressed; 
            return compressed;
        }
    }
    class CompressTests
    {
        [Test]
        public void Compress()
        {
            var compress = new StringCompressionClass();
            var expected = "a3b2";
            var actual = compress.Compress("aaabb");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Compress2()
        {
            var compress = new StringCompressionClass();
            var expected = "r4b1k8";
            var actual = compress.Compress("rrrrbkkkkkkkk");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void CompressCaseSensitive()
        {
            var compress = new StringCompressionClass();
            var expected = "G3r1h2I9b2";
            var actual = compress.Compress("GGGrhhIIIIIIIIIbb");
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void Compress3()
        {
            var compress = new StringCompressionClass();
            var expected = "reb"; //this test is testing the condition of the uncompressed string being shorter than the compressed string 
                //without this condition, the compressed string would have been "r1e1b1"
            var actual = compress.Compress("reb");
            Assert.AreEqual(expected, actual); 
        }
    }
}
