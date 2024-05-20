namespace TurboCollections;

public class Node
{
    public int value { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }

    public Node(int conValue)
    {
        value = conValue;
        //left = 
    }
        
    void GetLeftNode()
    {
        
    }
}
public class Tree<T>
{
    //Node<T> nodes;
    T value;
    Tree<T> left;   
    Tree<T> right;

    public int GetLeftTree(int nX) { return (nX * 2) + 1; }
    public int GetRightTree(int nX) { return (nX * 2) + 2; }
    
    //public Node<T> GetValue(int nX) { return }
}

public class TurboBinarySearchTree
{
    
}