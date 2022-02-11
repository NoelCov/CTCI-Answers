using SinglyLinkedListImplementation;

Node ReturnKthtoLast(int k, LinkedList ll)
{
    Node? fastPointer = ll.Head;
    Node? slowPointer = ll.Head;

    for (int i = 1; i < k; i++)
    {
        if (fastPointer.Next == null)
        {
            return ll.Head;
        }

        fastPointer = fastPointer.Next;
    }

    while (fastPointer.Next != null)
    {
        slowPointer = slowPointer.Next;
        fastPointer = fastPointer.Next;
    }

    return slowPointer;
}
// Time Complexity O(n)
// Space Complexity O(1)