using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;

public class DropdownImage : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdownImage;
    [SerializeField] private Sprite _spriteNapoli,_spriteJuve;
    [SerializeField] private Image _image;
    List<string> opzioni = new List<string> { "Immagine Napoli", "Immagine Juve"};

    void Start()
    {
        _image.gameObject.SetActive(false);
        _dropdownImage.ClearOptions();
        _dropdownImage.AddOptions(opzioni);
        _dropdownImage.onValueChanged.AddListener(CambiaImmagine);
    }

    public void CambiaImmagine(int index)
    {
        switch (index)
        {
            case 0:
                _image.sprite = _spriteNapoli;
                break;
            case 1:
                _image.sprite = _spriteJuve;
                break;
        }
        _image.gameObject.SetActive(true);
    }
}
