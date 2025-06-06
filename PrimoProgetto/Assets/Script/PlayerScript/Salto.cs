using UnityEngine;

public class Salto : MonoBehaviour
{
    [SerializeField] private float _jump;
    [SerializeField] private Rigidbody _rigidBody;
    private bool isGround,canJump;
    [SerializeField] private float _cooldown;
    [SerializeField] private float _defaultCooldownTime;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround && canJump)
        {
            Jump();
        }
        CoolDownJump();
    }
    private void Jump()
    {
        _rigidBody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
        canJump = false;
    }

    private void CoolDownJump()
    {
        if (canJump == false)
        {
            _cooldown -= Time.deltaTime;
            if (_cooldown <= 0)
            {
                canJump = true;
                _cooldown = _defaultCooldownTime;
            }
        }
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
