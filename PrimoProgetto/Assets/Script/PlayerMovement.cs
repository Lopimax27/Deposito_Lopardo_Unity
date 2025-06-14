using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody _rigidBody;
    private Vector3 _direction;

    void Awake()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetDirection();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        if (_direction != Vector3.zero)
        {
            //_rigidBody.MovePosition(_rigidBody.position + _direction * _speed * Time.fixedDeltaTime);
            _rigidBody.linearVelocity = _direction * _speed * Time.fixedDeltaTime;
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

    private void Jump()
    {
        _rigidBody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
    }
}
