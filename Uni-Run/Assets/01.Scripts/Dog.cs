using UnityEngine;

public class Dog : MonoBehaviour
{
    public string dogName; // ���� �̸�
    public static int count = 0; // ���α׷��� �����ϴ� ���� �� ��

    private void Awake()
    {
        count++;
        Debug.Log("Count : " + count);
    }
}
