using HackerRank.Sorting;
using NUnit.Framework;

namespace Test.HackerRank.Sorting
{
    public class FraudulentActivityNotificationsTests
    {
        [Test]
        public void ActivityNotifications01()
        {
            var expenditure = new int[]
            {
                2, 3, 4, 2, 3, 6, 8, 4, 5
            };

            var result = 2;

            Assert.AreEqual(result, FraudulentActivityNotifications.ActivityNotifications(expenditure, 5));
        }

        [Test]
        public void ActivityNotifications02()
        {
            var expenditure = new int[]
            {
                10, 20, 30, 40, 50
            };

            var result = 1;

            Assert.AreEqual(result, FraudulentActivityNotifications.ActivityNotifications(expenditure, 3));
        }
    }
}
