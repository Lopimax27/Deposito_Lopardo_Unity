using UnityEngine;

public class Movementabilities : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private MeshCollider _portale;
    private Vector3 _direction;


    void Update()
    {
        GetDirection();
    }

    void FixedUpdate()
    {
        if (_direction != Vector3.zero)
        {
            //_rigidBody.MovePosition(_rigidBody.position + _direction * _speed * Time.fixedDeltaTime);
            _rigidBody.linearVelocity += _direction * _speed * Time.fixedDeltaTime;
        }
    }

    private void GetDirection()
    {
        _direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _direction += Vector3.right;
        }
    }

    void OnTriggerEnter(Collider portale)
    {
        _speed *= 2;
        Debug.Log("Piuuu");
    }
}
