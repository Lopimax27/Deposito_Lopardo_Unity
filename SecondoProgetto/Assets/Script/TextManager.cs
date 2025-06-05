using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI testo;
    [SerializeField, TextArea] private string textOverride;
    [SerializeField] private Color colorOverride;
    [SerializeField] private Image image;


    void Update()
    {
        testo.text = textOverride;
        image.color = colorOverride;
    }



}
