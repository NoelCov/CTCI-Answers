namespace SinglyLinkedListImplementation
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }

        public Node(int val)
        {
            this.Value = val;
            this.Next = null;
        }

        public override string ToString()
        {
            return $"({this.Value})";
        }
    }
}
