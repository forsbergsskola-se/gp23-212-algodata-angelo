using TurboCollections;
namespace TurboCollections.Test;
public static class SelectionSortTests
{
    [Test]
    public static void TestSelectionSort()
    {
        //Test case: List {5, 6, 2, 8, 7}
        List<int> list = new List<int> { 5, 6, 2, 8, 7 };
        TurboSort.SelectionSorting(list);
        CollectionAssert.AreEqual(list, new [] {2, 5, 6, 7, 8});
    }
}