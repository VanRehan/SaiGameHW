using UnityEngine;

public class CurvedPath : MonoBehaviour
{
    public Transform[] points; // Point0, Point1, Point2
    public float duration = 5f;
    float t;

    void Update()
    {
        if (points.Length < 3) return;

        t += Time.deltaTime / duration;
        if (t > 1f) t = 0f;

        Vector3 a = Vector3.Lerp(points[0].position, points[1].position, t);
        Vector3 b = Vector3.Lerp(points[1].position, points[2].position, t);
        transform.position = Vector3.Lerp(a, b, t);
    }
}
