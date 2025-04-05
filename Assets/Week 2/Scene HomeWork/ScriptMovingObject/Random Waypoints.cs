using UnityEngine;

public class RandomPath : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 2f;
    int current = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, waypoints[current].position) < 0.1f)
            current = Random.Range(0, waypoints.Length);
    }
}
// Sử dụng scirpt này bằng cách: Tạo nhiều Empty Objects rải rác trên Plane → gán vào waypoints.
