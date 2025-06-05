using UnityEngine;

public class Salto : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody _rigidBody;
    private bool isGround;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            Jump();
        }
    }
    private void Jump()
    {
        _rigidBody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
