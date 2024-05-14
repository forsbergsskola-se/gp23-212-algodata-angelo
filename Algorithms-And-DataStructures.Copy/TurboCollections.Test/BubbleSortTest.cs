using TurboCollections;
namespace TurboCollections.Test;

public static class BubbleSortTests
{
    [Test]
    public static void TestBubbleSort()
    {
        //Test case: List {6, 5, 2, 8, 7}
        List<int> list = new List<int> { 6, 5, 2, 8, 7 };
        TurboSort.BubbleSort(list);
        CollectionAssert.AreEqual(list, new [] {2, 5, 6, 7, 8});
    }
}