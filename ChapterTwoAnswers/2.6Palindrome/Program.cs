using SinglyLinkedListImplementation;

// 1) Solution using array

// Time Complexity O(n)
// Space Complexity O(n)

//bool IsLinkedListPalindrome(LinkedList ll)
//{
//    if (ll.Head == null) return false;

//    List<int> vals = new List<int>();
//    Node? node = ll.Head;

//    while (node != null)
//    {
//        vals.Add(node.Value);    
//        node = node.Next;
//    }

//    int left = 0;
//    int right = vals.Count - 1;

//    while (left < right)
//    {
//        if (vals[left] != vals[right])
//        {
//            return false;
//        }

//        left++;
//        right--;
//    }

//    return true;
//}


// 2) Solution using Stack (uses half memory and half time than solution using array);
// Because we will only push half the elements in the linkedlist into the stacks and we will also compare those half elements
bool isLinkedListPalindrome(LinkedList ll)
{
    if (ll.Head == null || ll.Head.Next == null) return false;

    Stack<int> stack = new Stack<int>();
    Node? fastPointer = ll.Head;
    Node? slowPointer = ll.Head;

    while (fastPointer != null && fastPointer.Next != null)
    {
        stack.Push(slowPointer.Value);
        slowPointer = slowPointer.Next;
        fastPointer = fastPointer.Next.Next;
    }

    if (fastPointer != null)
    {
        slowPointer = slowPointer.Next;
    }

    while (slowPointer != null)
    {

        int top = stack.Pop();
        if (slowPointer.Value != top)
        {

            return false;
        }
        slowPointer = slowPointer.Next;
    }

    return true;
}
