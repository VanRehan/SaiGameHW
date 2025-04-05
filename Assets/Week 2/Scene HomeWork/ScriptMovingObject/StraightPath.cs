using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightPath : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
    public float speed = 2f;

    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
