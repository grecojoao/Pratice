using System.Collections.Generic;

namespace HackerRank.Nelogica
{
    public class Question03
    {
        private static SinglyLinkedListNode Head { get; set; } = null;
        public static SinglyLinkedListNode RemoveNodes(SinglyLinkedListNode listHead, int x)
        {
            var node = listHead;
            var listData = new List<int>();
            while (node != null)
            {
                if (node.data <= x)
                    listData.Add(node.data);
                node = node.next;
            }

            for (int i = listData.Count - 1; i >= 0; i--)
                InsertNode(listData[i]);

            return Head;
        }

        private static void InsertNode(int data)
        {
            var node = new SinglyLinkedListNode
            {
                data = data,
                next = null
            };

            if (Head == null)
                Head = node;
            else
                node.next = Head;

            Head = node;
        }
    }

    public class SinglyLinkedListNode
    {
        public int data { get; set; }
        public SinglyLinkedListNode next { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                SinglyLinkedListNode node = (SinglyLinkedListNode)obj;
                return (node.data == this.data);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
