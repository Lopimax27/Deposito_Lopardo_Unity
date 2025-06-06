using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownFunction : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdown;
    [SerializeField] private Image _image;

    void Start()
    {
        List<string> opzioni = new List<string> { "Rosso", "Blu", "Verde" };
        dropdown.ClearOptions();
        dropdown.AddOptions(opzioni);

        dropdown.onValueChanged.AddListener(CambiaColore);
    }

    public void CambiaColore(int index)
    {
        switch (index)
        {
            case 0:
                _image.color = Color.red;
                break;
            case 1:
                _image.color = Color.blue;
                break;
            case 2:
                _image.color = Color.green;
                break;
        }
    }

}
