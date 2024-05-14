namespace TurboCollections;

public static partial class TurboSort
{
    public static void BubbleSort(List<int> list)
    {
        int listSize = list.Count;
        
        for (int i = listSize - 1; i > 0; i--)
        {
            bool swapped = false;

            for (int j = 0; j != i; j++)
            { 
                if (list[j] > list[j + 1]) 
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                    swapped = true;
                } 
            }
            if (!swapped)
            {
                break;
            }
        }
    }
}