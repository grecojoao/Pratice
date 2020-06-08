using NUnit.Framework;
using HackerRank.Nelogica;

namespace Tests.Arrays
{
    public class Question04Tests
    {
        [Test]
        public void Braces()
        {
            var expectedStrings = new string[4]
            { "NO","YES", "NO", "YES" };

            var braces = new string[4]
                { "([[)",
                "{[()]}",
                "{[(])}",
                "{{[[(())]]}}" };
            Assert.AreEqual(expectedStrings, Question04.Braces(braces));
        }
    }
}
