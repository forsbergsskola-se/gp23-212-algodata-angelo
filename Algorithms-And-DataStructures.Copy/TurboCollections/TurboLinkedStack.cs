using System.Collections;

public class TurboLinkedStack<T> : IEnumerable<T> {
    class Node {
        public T Value;
        public Node Previous;
    }
    Node LastNode;

    public void Push(T item) {
        var newNode = new Node
        {
            Value = item,
            Previous = null
        };
        //Error handling: Init, otherwise => nullref
        if (LastNode == null) { LastNode = newNode; }
        else { LastNode.Previous = newNode; }
        LastNode = newNode;
    }

    public T Peek()
    {
        if (LastNode != null) { return LastNode.Value; }
        else { throw new NotImplementedException("Empty"); }
    }

    public T Pop()
    {
        if (LastNode == null) { throw new InvalidOperationException("The stack is empty");} //Error handling
        // 1. Save the Last Node locally so we can return the value later.
        T localNode = Peek();

        // 2. Now, assign the Last Node's Previous Node to be the Last Node.
        LastNode = LastNode.Previous;
        // -- This effectively removes the previously Last Node of the Stack
        // -- Imagine LastNode is customer 436
        // -- -- who remembered that customer 435 was before him.
        // -- We assign that before customer 435 to LastNode.
        // -- -- 435 knows that 434 was before him.
        // -- -- But he has no memory of customer 436.

        // Now, return the Value of the Node that you cached in Step 1.
        return localNode;
    }

    public void Clear()
    {
        // This one is incredibly easy. Just assign null to Field LastNode
        LastNode = null;
        // -- This is like pretending you never knew that there is any last customer.
        // -- by forgetting the latest customer, you forget them all.
    }

    public int Count {
        get{
            // Here, you need to do a while loop over all nodes
            // Similar to the previous PrintAllNodes Function
            // But instead of Printing Nodes, you just count how many Nodes you have visited
            // Similar to this:
            int count = 0;
            Node currentPoint = LastNode;
            while(currentPoint != null){
                count++;
                currentPoint = currentPoint.Previous;
            }
            return count;
        }
    }

    public IEnumerator<T> GetEnumerator() {
        // This one is a bonus and a bit more difficult.
        // You need to create a new class named Enumerator.
        // You find the details below.
        var enumerator = new Enumerator(LastNode);
        return enumerator;
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    class Enumerator : IEnumerator<T> {
        private Node CurrentNode;
        private Node FirstNode;
        private Node _lastNode;

        public Enumerator(Node lastNode) {
            _lastNode = lastNode;
        }

        public bool MoveNext(){
            // if we don't have a current node, we start with the first node
            if(CurrentNode == null){
                CurrentNode = FirstNode;
            } 
            else 
            {
                // Assign the Current Node's Previous Node to be the Current Node.
                CurrentNode = CurrentNode.Previous;
            }
            // Return, whether there is a CurrentNode. Else, we have reached the end of the Stack, there's no more Elements.
            return CurrentNode != null; //False == end of stack
        }

        public T Current {
            get
            {
                // Return the Current Node's Value.
                return CurrentNode.Value;
            }
        }

        // This Boiler Plate is necessary to correctly implement `IEnumerable` interface.
        object IEnumerator.Current => Current;

        public void Reset() {
            // Look at Move. How can you make sure that this Enumerator starts over again?
            CurrentNode = null; //Starts from beginning again
        }

        public void Dispose()
        {
            // This function is not needed right now.
        }
    }
}