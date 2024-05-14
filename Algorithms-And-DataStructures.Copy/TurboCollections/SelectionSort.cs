namespace TurboCollections;

public static partial class TurboSort
{
    public static void SelectionSorting(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++) //Each index will compare to the next in list
            {
                if (list[i] > list[j])
                {
                    (list[j], list[i]) = (list[i], list[j]);
                }
            }
        }
    }
}