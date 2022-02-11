using SinglyLinkedListImplementation;

LinkedList ll = new LinkedList(5);
ll.AppenToEnd(10);
ll.AppenToEnd(20);
ll.AppenToEnd(30);
ll.AppenToEnd(10);


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

Console.WriteLine(ReturnKthtoLast(10, ll));