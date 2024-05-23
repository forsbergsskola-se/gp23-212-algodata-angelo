namespace TurboCollections;

public class Node<T>
{
    public int value { get; set; }
    private Node<T> left { get; set; }
    private Node<T> right { get; set; }

    public Node(int conValue) //Constructor, new Node
    {
        value = conValue;
        left = null;
        right = null;
    }

    public Node<T> GetLeftChildNode(Tree<T> tree, int nX) //Return Left Node
    {
        return new Node<T>(tree.GetLeftTreeIndex(nX)); 
    }
    public Node<T> GetRightChildNode(Tree<T> tree, int nX) //Return Right Node
    {
        return new Node<T>(tree.GetRightTreeIndex(nX));
    }

    public T GetValue(Tree<T> tree, int nX) //Return Node in Index
    {
        return tree.GetValue(nX);
    }

    public void SetValue(int nX, Tree<T> tree, T value) //Set Node Value
    {
        tree.SetValue(nX, value);
    }
    
    
}
public class Tree<T>
{
    public T[] nodes;

    public Tree(int size) { nodes = new T[size]; } //Set size
    public int GetLeftTreeIndex(int nX) { return (nX * 2) + 1; } //Returning left index
    public int GetRightTreeIndex(int nX) { return (nX * 2) + 2; } //Returning right index
    public T GetValue(int nX) { return nodes[nX]; } //Returning value in index
    public void SetValue(int nX, T value) { nodes[nX] = value; } //Set value in index
}
