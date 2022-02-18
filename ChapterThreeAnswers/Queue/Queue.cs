using Stack;
using System.Text;

namespace Queue
{
    public class Queue<T>
    {
        public Node<T>? Front { get; set; }
        public Node<T>? Back { get; set; }
        public Queue() { }
        public Queue(Node<T> node)
        {
            this.Front = node;
            this.Back = node;
        }
        public void Add(Node<T> node)
        {
            if (this.Front == null && this.Back == null)
            {
                this.Front = node;
                this.Back = node;
            }
            else
            {
                this.Back.Next = node;
                this.Back = node;
            }
        }
        public void Add(T value)
        {
            Node<T> node = new(value);
            if (this.Front == null && this.Back == null)
            {
                this.Front = node;
                this.Back = node;
            }
            else
            {
                this.Back.Next = node;
                this.Back = node;
            }
        }
        public Node<T>? Remove()
        {
            if (this.Front == null) return null;

            if (this.Front.Next == null)
            {
                Node<T> prevFront = this.Front;
                this.Front = null;
                return prevFront;
            }

            Node<T> node = this.Front;
            this.Front = this.Front.Next;
            return node;
        }
        public Node<T>? Peek()
        {
            return this.Front;
        }
        public bool isEmpty()
        {
            return this.Front == null;
        }

        public override string ToString()
        {
            if (this.Front == null) return "Empty Queue";
            
            StringBuilder sb = new();
            Node<T> node = this.Front;

            while (node != null)
            {
                if (sb.Length == 0)
                {
                    sb.Append($"{node}");
                }
                else
                {
                    sb.Append($"=>{node}");
                }
                node = node.Next;
            }
            return sb.ToString();
        }
    }
}