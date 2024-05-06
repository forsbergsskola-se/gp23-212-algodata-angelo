using System.Collections;

List <int> list = new List<int>() {137, 1000, -200 };

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}

ArrayList multiType = new ArrayList() {true, "Forsbergs", 'a', 1000, .12f};

for (int i = 0; i < multiType.Count; i++)
{
    Console.Write(multiType[i] + " ");
}