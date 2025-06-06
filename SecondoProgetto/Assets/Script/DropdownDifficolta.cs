using TMPro;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class DropdownDifficolta : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _dropdownDifficolta;
    [SerializeField] private TextMeshProUGUI _difficolta;
    List<string> opzioni = new List<string> { "Facile", "Medio", "Difficile" };
    void Start()
    {
        _dropdownDifficolta.ClearOptions();
        _dropdownDifficolta.AddOptions(opzioni);

        
        _dropdownDifficolta.onValueChanged.AddListener(CambiaDifficolta);
    }

    public void CambiaDifficolta(int index)
    {
        _difficolta.text = "Difficoltà: ";
        switch (index)
        {
            case 0:
                _difficolta.text += opzioni[index].ToString();
                break;
            case 1:
                _difficolta.text += opzioni[index].ToString();
                break;
            case 2:
                _difficolta.text += opzioni[index].ToString();
                break;
        }
    }


}
