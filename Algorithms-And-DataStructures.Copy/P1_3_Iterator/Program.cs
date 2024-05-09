using System.Collections;
using TurboCollections;

List <int> list = new List<int>() {1,1,2,3,5};

IEnumerable<int> enumerableList = list;

IEnumerator <int> elements = enumerableList.GetEnumerator();
while (elements.MoveNext())
{
    Console.Write(elements.Current + " ");
}
//Sum up
int sumUp = 0;
foreach (int number in enumerableList)
{
    sumUp += number;
}
Console.WriteLine($"The sumup is: {sumUp}");

foreach (int number in TurboMaths.GetEvenNumbers(12)) { Console.Write(number + " "); }
Console.WriteLine(); //New line for printout
foreach (int number in TurboMaths.GetEvenNumbersList(12)) { Console.Write(number + " "); }

TurboMaths.GetEvenNumbers(1000000000);
TurboMaths.GetEvenNumbersList(1000000000); //Performance issue; the list require a large amount of memory