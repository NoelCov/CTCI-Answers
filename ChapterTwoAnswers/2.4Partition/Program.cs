using SinglyLinkedListImplementation;

LinkedList Partition(LinkedList ll, int partition)
{
    if (ll.Head == null || ll.Head.Next == null) return ll;

    Node prev = ll.Head;
    Node curr = ll.Head.Next;

    while (curr != null)
    {
        if (curr.Value < partition)
        {
            Node? next = curr.Next;
            curr.Next = ll.Head;
            ll.Head = curr;
            prev.Next = next;
            curr = next;
        }
        else
        {
            curr = curr.Next;
            prev = prev.Next;
        }
    }
    return ll;
}
// Time Complexity O(n)
// Space Complexity O(1)