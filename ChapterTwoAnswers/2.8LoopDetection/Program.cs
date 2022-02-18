using SinglyLinkedListImplementation;

// Time Complexity O(n)
// Space Complexity O(n)
Node LoopDetection(LinkedList ll)
{
    if (ll.Head == null || ll.Head == null) return new Node(0);

    Dictionary<Node, bool> hash = new Dictionary<Node, bool>();
    Node? node = ll.Head;

    while (node != null)
    {
        if (hash.ContainsKey(node))
        {
            return node;
        }

        hash.Add(node, true);
        node = node.Next;
    }
    return new Node(0);
}

/*
 * Another possible solution if we don't want to use space
 * would be to do a nested loop.
 * For this solution:
 * Time Complexity O(n^2), Space Complexity O(1)
 */

// Most Optimal Solution
Node LoopDetectionOptimal(LinkedList ll)
{
    if (ll.Head == null || ll.Head == null) return new Node(0);

    Node slow = ll.Head;
    Node fast = ll.Head;


}