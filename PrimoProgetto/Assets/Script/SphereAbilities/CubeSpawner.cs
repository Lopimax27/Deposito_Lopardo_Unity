using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _ballprefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _forceAmount;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject ballInstance = Instantiate(_ballprefab, _spawnPoint.position, Quaternion.identity);
            Rigidbody ballRigidbody = ballInstance.GetComponent<Rigidbody>();

            ballRigidbody.AddForce(transform.forward * _forceAmount, ForceMode.Impulse);
        }
    }
}
