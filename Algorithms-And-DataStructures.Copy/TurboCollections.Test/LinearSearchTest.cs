using TurboCollections;
namespace TurboCollections.Test;

public static class LinearSearchTest
{
    [Test]
    public static void TestLinearSearch()
    {
        List<int> list = new List<int>{1, 5, 6, 7, 9, 4};
        int result = TurboSearch.LinearSearch(list, 4);
        Assert.AreEqual(result, 5);
    }
}