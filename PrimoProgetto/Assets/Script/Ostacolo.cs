using TMPro;
using UnityEngine;

public class Ostacolo : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private TextMeshProUGUI _loseText;
    private float _timerLose = 0f, maxTimer = 3f;
    private bool lose=false;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _loseText.text = "HAI PERSO";
        _loseText.gameObject.SetActive(false);
    }
    void Update()
    {
        if (lose)
        {
            _timerLose += Time.deltaTime;
            _loseText.gameObject.SetActive(true);

            if (_timerLose > maxTimer)
            {
                _loseText.gameObject.SetActive(false);
                lose = false;
            }
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ostacolo"))
        {
            _rigidbody.position = _spawnPoint.position;
            _rigidbody.rotation = _spawnPoint.rotation;
            _rigidbody.angularVelocity = Vector3.zero;

            _timerLose = 0;
            lose = true;
        }


    }
}
