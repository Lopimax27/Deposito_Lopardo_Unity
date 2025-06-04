using UnityEngine;

public class JumpAbilities : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody _rigidBody;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        _rigidBody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
    }
}
