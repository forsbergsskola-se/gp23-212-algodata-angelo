using TurboCollections;
namespace TurboCollections.Test;

public static class QuickSortTests
{
    [Test]
    public static void TestQuickSort()
    {
        //Test case: List {6, 5, 2, 8, 7}
        List<int> list = new List<int> { 6, 5, 2, 8, 7 };
        TurboSort.QuickSort(list,0,list.Count -1);
        CollectionAssert.AreEqual(list, new [] {2, 5, 6, 7, 8});
    }
}