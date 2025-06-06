using TMPro;
using UnityEngine;

public class Vittoria : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _canzoneeNapoli; // Assegna la canzone nell'Inspector
    [SerializeField] private TextMeshProUGUI _winText;
    private bool win=false;
    private float timer;
    private bool _endGame = false;
    [SerializeField] private TextMeshProUGUI _timerText;

    void Awake()
    {
        // Ottieni l'AudioSource se non assegnato
        if (_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
            if (_audioSource == null)
            {
                _audioSource = gameObject.AddComponent<AudioSource>();
            }
        }
    }

    void Update()
    {
        if (!_endGame)
        {
            timer += Time.deltaTime;
            _timerText.text = timer.ToString("F2");
        }
    }

    void OnTriggerEnter(Collider player) // Corretto il nome del metodo
    {
        win = true;
        _winText.text = "HAI VINTO";
        _winText.gameObject.SetActive(true);
        _endGame = true;

        // Riproduci la canzone del Napoli
        if (_canzoneeNapoli != null && _audioSource != null)
        {
            _audioSource.clip = _canzoneeNapoli;
            _audioSource.Play();
        }
    }
}