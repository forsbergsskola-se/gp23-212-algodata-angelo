using TurboCollections;
namespace TurboCollections.Test;

public static class TurboTreeTest
{
    [Test]
    public static void TestTurboTree()
    {
        Tree<int> tree = new Tree<int>(10);
        tree.SetValue(0, 10);
        tree.SetValue(1, 5);
        tree.SetValue(2,12);
        
        Assert.AreEqual(tree.nodes[0], 10);
        Assert.AreEqual(tree.nodes[1], 5);
        Assert.AreEqual(tree.nodes[2], 12);
        
    }
}