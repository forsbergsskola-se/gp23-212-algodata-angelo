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

    public static int BinarySearch<T>(IList<T> list, T targetValue) where T : IComparable<T>
    {
        int lowerBound = 0;
        int upperBound = list.Count - 1;

        while (upperBound >= lowerBound)
        {
            int midPoint = (lowerBound + upperBound) / 2;

            int compTResult = targetValue.CompareTo(list[midPoint]); // Either returns 0, - or +
            
            if (compTResult == 0)
            {
                return midPoint;
            } 
            else if (compTResult < 0) { upperBound = midPoint--; //Set new upper limit
            }
            else { lowerBound = midPoint++; // Set new lower limit
            }
        }
        return -1; //If search is unsuccessful
    }
}