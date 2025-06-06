using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ToggleFunction : MonoBehaviour
{
    [SerializeField] private GameObject hamburger;
    [SerializeField] private Image _napoli;
    [SerializeField] private TextMeshProUGUI _description;
    [SerializeField] private TextMeshProUGUI _attivoONo;

    void Start()
    {
        hamburger.SetActive(false);
        _description.gameObject.SetActive(false);
        _napoli.gameObject.SetActive(false);
    }

    public void SpawnHamburger()
    {
        if (!hamburger.activeSelf)
        {
            hamburger.SetActive(true);
        }
        else
        {
            hamburger.SetActive(false);
        }
    }

    public void DescriptionToggle()
    {
        if (!_description.gameObject.activeSelf)
        {
            _description.gameObject.SetActive(true);
        }
        else
        {
            _description.gameObject.SetActive(false);
        }
    }

    public void NapoliToggle()
    { 
        if (!_napoli.gameObject.activeSelf)
        {
            _napoli.gameObject.SetActive(true);
        }
        else
        {
            _napoli.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (_description.gameObject.activeSelf)
        {
            _attivoONo.text = "Descrizione Attiva";
        }
        else
        {
            _attivoONo.text = "Descrizione Disattivata";
        }
    }
}
