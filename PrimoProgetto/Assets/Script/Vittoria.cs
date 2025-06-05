using UnityEngine;

public class Vittoria : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _canzoneeNapoli; // Assegna la canzone nell'Inspector

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

    void OnTriggerEnter(Collider player) // Corretto il nome del metodo
    {
        Debug.Log("Hai Vinto");
        
        // Riproduci la canzone del Napoli
        if (_canzoneeNapoli != null && _audioSource != null)
        {
            _audioSource.clip = _canzoneeNapoli;
            _audioSource.Play();
        }
    }
}