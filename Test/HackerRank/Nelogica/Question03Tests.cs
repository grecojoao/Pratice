using NUnit.Framework;
using HackerRank.Nelogica;

namespace Tests.Arrays
{
    public class Question03Tests
    {
        [Test]
        public void RemoveNodes()
        {
            var listHead = new SinglyLinkedListNode
            {
                data = 100,
                next = new SinglyLinkedListNode
                {
                    data = 105,
                    next = new SinglyLinkedListNode
                    {
                        data = 50,
                        next = null
                    }
                }
            };

            var expectedListHead = new SinglyLinkedListNode
            {
                data = 100,
                next = new SinglyLinkedListNode
                {
                    data = 50,
                    next = null
                }
            };
            var resultList = Question03.RemoveNodes(listHead, 100);

            while (resultList != null)
            {
                Assert.True(expectedListHead.Equals(resultList));
                
                expectedListHead = expectedListHead.next;
                resultList = resultList.next;
            }
        }
    }
}
