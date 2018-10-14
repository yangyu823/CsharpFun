# SortedSearch

## Requist
<br/>
Implement function CountNumbers that accepts a sorted array of integers 
<br/>
and counts the number of array elements that are less than the parameter lessThan.


## For example
<br/>
SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4) 
<br/>
should return 2 because there are two array elements less than 4.

```C#
using System;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}

```

### (Tips: Use BinarySearch to get the position of provided parameter）
