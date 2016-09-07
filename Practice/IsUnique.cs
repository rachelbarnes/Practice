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
        public bool IsUnique(string AmIUnique)
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
        public bool IsUniqueAgain(string AmIUnique)
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







        public class IsUniqueTests
        {
            [Test]
            public void IsUnique1()
            {
                var myClass = new IsUniqueClass();
                var expected = true;
                var actual = myClass.IsUnique("Another");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void IsUnique2()
            {
                var myClass = new IsUniqueClass();
                var expected = false;
                var actual = myClass.IsUnique("Extravagant");
                Assert.AreEqual(expected, actual);
            }
            //testing the second method, IsUniqueAgain
            [Test]
            public void IsUnique3()
            {
                var myClass = new IsUniqueClass();
                var expected = true;
                var actual = myClass.IsUniqueAgain("Share");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void IsUnique4()
            {
                var myClass = new IsUniqueClass();
                var expected = false;
                var actual = myClass.IsUniqueAgain("Kitty");
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void LookingAtThePalPerm()
            {
                var myClass = new IsUniqueClass();
                var expected = true;
                var actual = myClass.PalPerm("mlkthtmlk");
                Assert.AreEqual(expected, actual);
            }
        }
    }
