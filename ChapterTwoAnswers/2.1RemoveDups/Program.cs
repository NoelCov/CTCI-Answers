using SinglyLinkedListImplementation;

LinkedList ll = new LinkedList(10);

// Time Complexity O(n)
// Space Complexity O(n)
LinkedList RemoveDupsUsingHashTable(LinkedList ll)
{
    if (ll.Head == null)
    {
        return ll;
    }

    Dictionary<int, bool> hash = new Dictionary<int, bool>();
    Node? prev = null;
    Node? curr = ll.Head;

    while (curr != null)
    {
        if (hash.ContainsKey(curr.Value))
        {
            if (curr.Next == null)
            {
                prev.Next = null;
                ll.Tail = prev;

                return ll;
            }
            else
            {
                Node next = curr.Next;
                curr.Next = null;
                prev.Next = next;
                curr = next;
                continue;
            }
        }
        else
        {
            hash.Add(curr.Value, true);
            prev = curr;
            curr = curr.Next;
        }
    }
    return ll;
}

// Time Complexity O(n^2)
// Space Complexity O(1)
LinkedList RemoveDupsUsingTwoPointers(LinkedList ll)
{
    if (ll.Head == null) return ll;

    Node? former = ll.Head;
    Node? curr = ll.Head.Next;
    Node? prev = null;

    while (former.Next != null)
    {
        while (curr != null)
        {
            if (former.Value == curr.Value)
            {
                if (prev == null)
                {
                    former.Next = null;
                    return ll;
                }
                else
                {
                    Node? next = curr.Next;
                    curr.Next = null;
                    curr = next;
                    prev.Next = curr;
                    continue;
                }
            }
            prev = curr;
            curr = curr.Next;
        }

        former = former.Next;
        curr = former.Next;
        prev = null;
    }

    return ll;
}