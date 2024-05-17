using TurboCollections;
namespace TurboCollections.Test;

public static class BinarySearchTest
{
    [Test]
    public static void TestBinarySearch()
    {   
        List<int> list = new List<int>{1, 5, 6, 7, 9, 4};
        int result = TurboSearch.BinarySearch(list, 9);
        Assert.AreEqual(result, 4);
    }
}