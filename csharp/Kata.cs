using System.Collections.Generic;
public class Kata
{
    public static int[] AddingShifted(int[][] arrayOfArrays, int shift)
    {

        // start from the first array
        int[] result = arrayOfArrays[0];
        for(int i = 0; i < arrayOfArrays.Length - 1; i++)
        {
            result = Add(result, arrayOfArrays[i + 1], shift * (i + 1));
        }

        return result;
    }

    /// <summary>
    /// Add 2 arrays 
    /// </summary>
    /// <param name="array1"></param>
    /// <param name="array2"></param>
    /// <param name="shift"></param>
    /// <returns></returns>
    static int[] Add(int[] array1, int[] array2, int shift)
    {
        List<int> list = new List<int>();

        int i = 0;
        int j = 0;

        for (i = 0; i < array1.Length; i++)
        {
            if (i < shift)
            {
                // array 1 only
                list.Add(array1[i]);
            }
            else
            {
                // add
                list.Add(array1[i] + array2[i - shift]);
                j++;
            }
        }

        // remain of array 2
        for (; j < array2.Length; j++)
        {
            list.Add(array2[j]);
        }

        return list.ToArray();
    }
}

