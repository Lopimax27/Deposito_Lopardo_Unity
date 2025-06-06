using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinestraFunction : MonoBehaviour
{
    [SerializeField] private Image _window;
    [SerializeField] private TextMeshProUGUI _text;

    void Start()
    {
        _window.gameObject.SetActive(false);
        _text.gameObject.SetActive(false);
    }

    public void OpenWindow()
    {
        _window.gameObject.SetActive(true);
        _text.text = "";
        _text.gameObject.SetActive(false);
    }

    public void Conferma()
    {
        _window.gameObject.SetActive(false);
        _text.text ="Forza Napoli";
        _text.gameObject.SetActive(true);
    }

    public void Annulla()
    { 
        _window.gameObject.SetActive(false);
    }
}
