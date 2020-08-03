/*
 * C# Program to Perform a Selection Sort
 */
using System;
class Program
{
    private void Sort(int[] arr)
    {
        int i, j, min;
        for (i = 0; i < arr.Length; i++)
        {
            min = i;
            for (j = 0; j < arr.Length; j++)
            {
                if (arr[j] > arr[min])
                {
                    min = j;
                    Swap(ref arr[i], ref arr[min]);
                }
            }
        }
    }

    private void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }


