using UnityEngine;

public class BuffVelocità : MonoBehaviour
{
    private float _speed;
    void Awake()
    {
        _speed = GetComponent<float>();
    }
}
