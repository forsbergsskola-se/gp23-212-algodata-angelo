namespace TurboCollections;

public class TurboSearch
{
    public static int LinearSearch<T>(IEnumerable<T> SearchList, T target)
    {
        int indexPointer = 0;
        foreach (T value in SearchList)
        {
            if (!EqualityComparer<T>.Default.Equals(target, value)) //Note: cannot use standard operators to generic types
            {
                indexPointer++;
            }
            else { return indexPointer; }
        }
        return -1; // =Search unsuccessful
    }
}