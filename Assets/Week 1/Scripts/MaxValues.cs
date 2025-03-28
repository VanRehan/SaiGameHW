using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValues : MonoBehaviour
{
    void Start()
    {
        // Giá trị lớn nhất của int
        int maxInt = int.MaxValue;
        Debug.Log("Giá trị lớn nhất của int: " + maxInt);

        // Giá trị lớn nhất của float
        float maxFloat = float.MaxValue;
        Debug.Log("Giá trị lớn nhất của float: " + maxFloat);

        // Giá trị lớn nhất của double
        double maxDouble = double.MaxValue;
        Debug.Log("Giá trị lớn nhất của double: " + maxDouble);
    }
}
// Giá trị lớn nhất của int: 2147483647
//  Giá trị lớn nhất của float: 3.402823E+38
// Giá trị lớn nhất của double: 1.79769313486232E+308