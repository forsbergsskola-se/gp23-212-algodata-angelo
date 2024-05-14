namespace TurboCollections;

public static partial class TurboSort
{ 
    public static void QuickSort(List<int> list, int low, int high)
    {
        if (low <= high)
        {
            int partitionIndex = Partition(list, low, high);
            QuickSort(list, low, partitionIndex - 1);
            QuickSort(list, partitionIndex + 1, high);
        }
    }

    public static int Partition(List<int> list, int low, int high)
    {
        int pivotHigh = list[high];
        int partitionIndex = low;

        for (int j = low; j < high; j++)
        {
            if (list[j] < pivotHigh)
            {
                (list[partitionIndex], list[j]) = (list[j], list[partitionIndex]);
                partitionIndex++;
            }
        }

        (list[partitionIndex], list[high]) = (list[high], list[partitionIndex]);
        return partitionIndex;
    }
}