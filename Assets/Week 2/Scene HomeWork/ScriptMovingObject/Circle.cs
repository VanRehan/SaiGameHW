using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularPath : MonoBehaviour
{
    public Transform center;
    public float radius = 3f;
    public float speed = 2f;
    float angle;

    void Update()
    {
        angle += speed * Time.deltaTime;
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        transform.position = center.position + new Vector3(x, 0, z);
    }
}
// Sử dung script này bằng cách tạo một point để làm điểm neo để di chuyển vòng tròn điểm neo đó
