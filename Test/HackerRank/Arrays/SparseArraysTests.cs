using HackerRank.Arrays;
using NUnit.Framework;

namespace Test.HackerRank.Arrays
{
    public class SparseArraysTests
    {
        [Test]
        public void MatchingStrings01()
        {

            var imput = new string[]
            {
                "aba",
                "baba",
                "aba",
                "xzxb"
            };

            var queries = new string[]
            {
                "aba",
                "xzxb",
                "ab"
            };

            var result = new int[]
            {
                2,
                1,
                0
            };

            Assert.AreEqual(result, SparseArrays.MatchingStrings(imput, queries));
        }

        [Test]
        public void MatchingStrings02()
        {

            var imput = new string[]
            {
                "abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf",
                "na",
                "asdjf",
                "na",
                "basdn",
                "sdaklfj",
                "asdjf"
            };

            var queries = new string[]
            {
                "abcde",
                "sdaklfj",
                "asdjf",
                "na",
                "basdn"
            };

            var result = new int[]
            {
                1,
                3,
                4,
                3,
                2
            };

            Assert.AreEqual(result, SparseArrays.MatchingStrings(imput, queries));
        }
    }
}
