using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1
    // Bubble Sort

    // Sort Algorithm 2
    // Quick Sort

    // Sort Algorithm 3
    // Merge Sort

    // Sort Algorithm 4
    // insertion Sort

    // Sort Algorithm 5
    // Selection Sort

    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        //Insert Algorithm here
        for (int i = 1; i < randomNumbers.Length; i++)
        {
            int key = randomNumbers[i];
            int j = i - 1;
            while (j >= 0 && randomNumbers[j] > key)
            {
                randomNumbers[j + 1] = randomNumbers[j];
                j--;
            }
            randomNumbers[j + 1] = key;
        }
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
