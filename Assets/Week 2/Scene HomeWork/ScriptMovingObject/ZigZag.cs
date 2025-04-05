using UnityEngine;

public class ZigzagPath : MonoBehaviour
{
    public float speed = 2f;
    public float frequency = 2f;
    public float magnitude = 1f;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float x = Mathf.Sin(Time.time * frequency) * magnitude;
        transform.position = startPos + new Vector3(x, 0, Time.time * speed);
    }
}
