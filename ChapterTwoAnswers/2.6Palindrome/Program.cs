using SinglyLinkedListImplementation;

bool IsLinkedListPalindrome(LinkedList ll)
{
    if (ll.Head == null) return false;

    List<int> vals = new List<int>();
    Node? node = ll.Head;

    while (node != null)
    {
        vals.Add(node.Value);    
        node = node.Next;
    }

    int left = 0;
    int right = vals.Count - 1;
    
    while (left < right)
    {
        if (vals[left] != vals[right])
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}

// Time Complexity O(n)
// Space Complexity O(n)

