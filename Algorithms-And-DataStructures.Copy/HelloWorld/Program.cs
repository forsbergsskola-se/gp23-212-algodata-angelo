namespace TurboCollections;

public class Program
{
    static void Main(string[] args)
    {
        var bst = new BinarySearchTree<int>();

        // Insert values
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(20);
        bst.Insert(15);
        bst.Insert(30);

        // Get maximum value
        Console.WriteLine("Max Value: " + bst.GetMaxValue()); // Output: 30

        // Delete a node
        bst.Delete(20);

        // Get maximum value after deletion
        Console.WriteLine("Max Value after deletion: " + bst.GetMaxValue()); // Output: 30
    }
}