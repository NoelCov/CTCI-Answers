﻿using System.Text;

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

        public override string ToString(    )
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
            else
            {
                this.Tail.Next = newTail;
                this.Tail = newTail;
            }
        }

        public void AppendToEnd(Node node)
        {
            if (this.Tail == null) this.Tail = node;
            else
            {
                this.Tail.Next = node;
                this.Tail = node;
            }
        }

        public void AppendToFront(int val)
        {
            Node newHead = new Node(val);

            if (this.Head == null) this.Head = newHead;
            else
            {
                Node prevHead = this.Head;
                newHead.Next = prevHead;
                this.Head = newHead;
            }
        }

        public void AppendToFront(Node node)
        {
            if (this.Head == null) this.Head = node;
            else
            {
                node.Next = this.Head;
                this.Head = node;
            }
        }
    }
}
