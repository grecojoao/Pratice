using HackerRank.Ordenation;
using NUnit.Framework;

namespace Test.HackerRank.Ordenation
{
    public class QuickSortTest
    {
        [Test]
        public void Order()
        {
            var array = new int[] { 3, 7, 8, 5, 2, 1, 9, 5, 4 };
            var expected = new int[] { 1, 2, 3, 4, 5, 5, 7, 8, 9 };
            QuickSort.Order(array, 0, array.Length-1);
            Assert.AreEqual(array, expected);
        }
    }
}