using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; // 이동 속도

    void Update()
    {
        // 초당 speed의 속도로 왼쪽으로 평행이동
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
