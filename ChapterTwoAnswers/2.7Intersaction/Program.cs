using SinglyLinkedListImplementation;

// Time Complexity O(n);
// Space Complexity O(1);

Node IntersectionNode(LinkedList ll1, LinkedList ll2)
{
    if (ll1.Head == null || ll2.Head == null)
    {
        return new Node(0);
    }

    if (ll1.Tail != ll2.Tail)
    {
        return new Node(0);
        // Or throw exception
    }

    int ll1Lenght = getLength(ll1);
    int ll2Lenght = getLength(ll2);

    Node? firstPointer = ll1.Head;
    Node? secondPointer = ll2.Head;

    if (ll1Lenght != ll2Lenght)
    {
        if (ll1Lenght > ll2Lenght)
        {

            traverseLongList(ll1, ll1Lenght - ll2Lenght);
        }
        else
        {
            traverseLongList(ll2, ll2Lenght - ll1Lenght);
        }
    }

    while (firstPointer != secondPointer)
    {
        firstPointer = firstPointer.Next;
        secondPointer = secondPointer.Next;
    }

    return firstPointer;
}

int getLength(LinkedList ll)
{
    if (ll.Head == null) return 0;

    Node? node = ll.Head;
    int counter = 0;

    while (node != null)
    {
        counter++;
        node = node.Next;
    }
    return counter;
}

Node? traverseLongList(LinkedList ll, int length)
{
    Node node = ll.Head;
    for (int i = 0; i < length; i++)
    {
        node = node.Next;
    }

    return node;
}

//Node firstNode = new(5);
//Node secondNode = new(10);
//Node thirdNode = new(20);

//secondNode.Next = thirdNode;

//firstNode.Next = secondNode;

//Node otherFirstNode = new(5);
//otherFirstNode.Next = secondNode;

//LinkedList ll1 = new LinkedList(10);
//ll1.AppenToEnd(2);
//ll1.AppendToEnd(firstNode);

//LinkedList ll2 = new LinkedList(8);
//ll2.AppenToEnd(2);
//ll2.AppendToEnd(firstNode);

//Console.WriteLine(IntersectionNode(ll1, ll2));