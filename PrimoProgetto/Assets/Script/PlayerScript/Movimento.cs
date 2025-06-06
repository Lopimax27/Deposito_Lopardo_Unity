using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private float _rotationSpeed; // Velocità di rotazione
    private float _rotationInput;
    private float _defaultSpeed;
    private Vector3 _direction;

    void Start()
    {
        _defaultSpeed = _speed;
    }

    void Update()
    {
        GetDirection();
        GetRotation();
    }

    void FixedUpdate()
    {
        if (_direction != Vector3.zero)
        {
            _rigidBody.linearVelocity += _direction * _speed * Time.fixedDeltaTime;
        }
        if (_rotationInput != 0f)
        {
            transform.Rotate(0,_rotationInput * _rotationSpeed * Time.fixedDeltaTime, 0);
        }
    }

    private void GetDirection()
    {
        _direction = Vector3.zero;
        _speed = _defaultSpeed;

        if (Input.GetKey(KeyCode.W))
        {
            _direction += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _direction += -transform.forward;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _speed *= 2;
        }
    }

    private void GetRotation()
    {
        _rotationInput = 0;

        if (Input.GetKey(KeyCode.A))
        {
            _rotationInput += -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rotationInput += 1f;
        }
    }

}
