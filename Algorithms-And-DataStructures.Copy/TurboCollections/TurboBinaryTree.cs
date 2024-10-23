namespace TurboCollections
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public BinarySearchTree()
        {
            root = null;
        }

        // Insert a new value into the BST
        public void Insert(T value)
        {
            root = InsertRecursive(root, value);
        }

        private Node<T> InsertRecursive(Node<T> node, T value)
        {
            // If we reached a leaf node (childless), create a new node
            if (node == null)
            {
                return new Node<T>(value);
            }

            // Compare the value with the current node's value
            int comparison = value.CompareTo(node.Value);

            // If smaller, go to the left subtree
            if (comparison < 0)
            {
                node.Left = InsertRecursive(node.Left, value);
            }
            // If greater, go to the right subtree
            else
            {
                node.Right = InsertRecursive(node.Right, value);
            }

            return node;
        }

        // Search for a value in the BST
        public bool Search(T value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(Node<T> node, T value)
        {
            // If the node is null, the value is not in the tree
            if (node == null)
            {
                return false;
            }

            // Compare the value with the current node's value
            int comparison = value.CompareTo(node.Value);

            if (comparison == 0)
            {
                return true; // Found the value
            }
            else if (comparison < 0)
            {
                // Search the left subtree
                return SearchRecursive(node.Left, value);
            }
            else
            {
                // Search the right subtree
                return SearchRecursive(node.Right, value);
            }
        }
        // Delete a value from the BST
        public void Delete(T value)
        {
            root = DeleteRecursive(root, value);
        }

        private Node<T> DeleteRecursive(Node<T> node, T value)
        {
            if (node == null)
            {
                return null; // Value not found
            }

            int comparison = value.CompareTo(node.Value);

            if (comparison < 0)
            {
                node.Left = DeleteRecursive(node.Left, value); // Search left subtree
            }
            else if (comparison > 0)
            {
                node.Right = DeleteRecursive(node.Right, value); // Search right subtree
            }
            else
            {
                // Case 1: No children (leaf node)
                if (node.Left == null && node.Right == null)
                {
                    return null;
                }
                // Case 2: One child
                else if (node.Left == null)
                {
                    return node.Right; // Replace with right child
                }
                else if (node.Right == null)
                {
                    return node.Left; // Replace with left child
                }
                // Case 3: Two children
                else
                {
                    // Find the minimum value in the right subtree
                    Node<T> minValueNode = FindMin(node.Right);
                    node.Value = minValueNode.Value; // Replace current node value with min value
                    node.Right = DeleteRecursive(node.Right, minValueNode.Value); // Delete the min value node
                }
            }

            return node;
        }

        // Find the minimum value node in a subtree
        private Node<T> FindMin(Node<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        // Get the maximum value in the BST
        public T GetMaxValue()
        {
            if (root == null)
            {
                throw new InvalidOperationException("Tree is empty.");
            }

            return GetMaxValueRecursive(root);
        }

        private T GetMaxValueRecursive(Node<T> node)
        {
            if (node.Right == null)
            {
                return node.Value; // Rightmost node is the max value
            }

            return GetMaxValueRecursive(node.Right);
        }
    }
}