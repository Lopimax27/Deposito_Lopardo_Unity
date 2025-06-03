using UnityEngine;

public class CylinderMovement : MonoBehaviour
{
    private Vector3 _direzione;

    [SerializeField] private float _speedTransform;
    [SerializeField] private float _speedMovement;
    [SerializeField] private Rigidbody _rigidBody;

    void Awake() => Debug.Log("Awake");
    void OnEnable() => Debug.Log("OnEnable");
    void Start() => Debug.Log("Start");

    void Update()
    {
        Debug.Log(transform.position);
        Debug.Log(transform.localPosition);
    }

    void FixedUpdate()
    {
        Debug.Log("Mi muovo");
        MovePosition();
        MoveTransform();
    }

    private void MovePosition()
    {
        _direzione=Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            _direzione += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _direzione += Vector3.back;
        }
        _rigidBody.MovePosition(_rigidBody.position + _direzione * _speedMovement * Time.fixedDeltaTime);
    }

    private void MoveTransform()
    {
        _direzione=Vector3.zero;
        
        if (Input.GetKey(KeyCode.A))
        {
            _direzione = Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _direzione = Vector3.right;
        }
        transform.position += _direzione * _speedTransform * Time.fixedDeltaTime;
    }
    

}
