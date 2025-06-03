using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    [SerializeField] private Rigidbody _rigidBody;

    void Awake()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidBody.MovePosition(_rigidBody.position + Vector3.forward * _speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidBody.MovePosition(_rigidBody.position + Vector3.left * _speed*Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidBody.MovePosition(_rigidBody.position + Vector3.back * _speed*Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidBody.MovePosition(_rigidBody.position + Vector3.right * _speed*Time.fixedDeltaTime);
        }
    }
}
