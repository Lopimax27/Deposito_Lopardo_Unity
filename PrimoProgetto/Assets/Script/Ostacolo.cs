using UnityEngine;

public class Ostacolo : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private Transform _spawnPoint;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ostacolo"))
        {
            _rigidbody.position = _spawnPoint.position;
            _rigidbody.rotation = _spawnPoint.rotation;
            _rigidbody.angularVelocity = Vector3.zero;
        }
    }
}
