using System.Text;

namespace Stack
{
    public class Stack<T>
    {
        public Node<T> TopValue { get; set; }

        public Stack(T value)
        {
            this.TopValue = new Node<T>(value);
        }

        bool isEmpty() => this.TopValue == null;
        Node<T>? Peek() => this.TopValue;
        void Push(Node<T> node)
        {
            if (this.TopValue == null)
            {
                this.TopValue = node;
            } else
            {
                node.Next = this.TopValue;
                this.TopValue = node;
            }
        }
        Node<T>? Pop()
        {
            if (this.TopValue == null) return null;

            Node<T>? prevTop = this.TopValue;
            this.TopValue = this.TopValue.Next;
            return prevTop;
        }

        public override string ToString()
        {
            if (this.TopValue == null) return "Stack is empty";

            StringBuilder sb = new StringBuilder();

            Node<T>? node = this.TopValue;

            while (node != null)
            {
                sb.Append($"{node.Value}\n");
                node = node.Next;
            }
            return sb.ToString();
        }
    }
}