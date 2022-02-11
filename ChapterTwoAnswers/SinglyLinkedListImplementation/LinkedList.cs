using System.Text;

namespace SinglyLinkedListImplementation
{
    public class LinkedList
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }

        public LinkedList()
        {
            this.Head = null;
            this.Tail = null;
        }

        public LinkedList(int head)
        {
            Node node = new Node(head);

            this.Head = node;
            this.Tail = node;
        }

        public override string ToString()
        {
            if (this.Head == null)
            {
                return "Empty Linked List";
            }

            StringBuilder sb = new StringBuilder();

            Node currentNode = this.Head;

            while (currentNode != null)
            {
                sb.Append($"({currentNode.Value})");

                if (currentNode.Next != null)
                {
                    sb.Append("=>");
                }
                currentNode = currentNode.Next;
            }

            return sb.ToString();
        }

        public void AppenToEnd(int val)
        {
            Node newTail = new Node(val);

            if (this.Tail == null) this.Tail = newTail;

            this.Tail.Next = newTail;
            this.Tail = newTail;
        }

        public void AppendToFront(int val)
        {
            Node newHead = new Node(val);

            if (this.Head == null) this.Head = newHead;

            Node prevHead = this.Head;
            newHead.Next = prevHead;
            this.Head = newHead;
        }
    }
}
