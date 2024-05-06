using TurboCollections;
namespace TurboCollections.Test;
public static class TurboMathsTests
{
    //Hello World
    [Test]
    public static void SayHelloExists()
    {
        TurboMaths.SayHello();

        Assert.Pass();
    }

    //P1_3
    [Test]
    public static void TestGetEvenNumbers()
    {
        //Test Case: GetEvenNumbersList(12) -> {0, 2, 4, 8, 10, 12};
        CollectionAssert.AreEqual(new[] {0,2,4,6,8,10,12}, TurboMaths.GetEvenNumbers(12));

        //Test Case:  GetEvenNumbersList(15) -> {0, 2, 4, 8, 10, 12, 14};
        CollectionAssert.AreEqual(new[] {0,2,4,6,8,10,12, 14}, TurboMaths.GetEvenNumbers(15));

        //Test Case:  GetEvenNumbersList(-1) -> {};
        CollectionAssert.AreEqual(null, TurboMaths.GetEvenNumbers(-1));
        
        //Test Case:  GetEvenNumbersList(0) -> {0};
        CollectionAssert.AreEqual(new [] {0}, TurboMaths.GetEvenNumbers(0));
    }
    public static void TestGetEvenNumbersList()
    {
        //Test Case: GetEvenNumbersList(12) -> {0, 2, 4, 8, 10, 12};
        CollectionAssert.AreEqual(new[] {0,2,4,6,8,10,12}, TurboMaths.GetEvenNumbersList(12));

        //Test Case:  GetEvenNumbersList(15) -> {0, 2, 4, 8, 10, 12, 14};
        CollectionAssert.AreEqual(new[] {0,2,4,6,8,10,12, 14}, TurboMaths.GetEvenNumbersList(15));
        
        //Test Case:  GetEvenNumbersList(-1) -> {};
        CollectionAssert.AreEqual(null, TurboMaths.GetEvenNumbersList(-1));
        
        //Test Case:  GetEvenNumbersList(0) -> {0};
        CollectionAssert.AreEqual(new [] {0}, TurboMaths.GetEvenNumbersList(0));
    }
}