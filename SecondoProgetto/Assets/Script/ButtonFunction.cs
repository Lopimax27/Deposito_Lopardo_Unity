using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunction : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _testoPunt;
    private int _punteggio;

    public void OnClickAzioneEseguita()
    {
        Debug.Log("Pulsante Premuto");
    }

    public void OnClickAumentaPunteggio()
    {
        _punteggio++;
        _testoPunt.text = _punteggio.ToString();
    }

    public void OnClickDiminuisciPunteggio()
    {
        _punteggio--;
        _testoPunt.text = _punteggio.ToString();
    }
}
