using TurboCollections;
namespace TurboCollections.Test;

public static class TurboTreeTest
{
    [Test]
    public static void TestTurboTree()
    {
        Tree<int> tree = new Tree<int>(10);
        tree.SetValue(0, new Node<int>(10));
        tree.SetValue(1, new Node<int>(5));
        tree.SetValue(2,new Node<int>(12));
        Node<int> temp = tree.GetValue(1);
        
        Assert.AreEqual(tree.nodes[0].value, 10);
        Assert.AreEqual(temp.value, 5);
        Assert.AreEqual(tree.nodes[2].value, 12);
        
        
    }
}