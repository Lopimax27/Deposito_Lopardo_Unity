using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    [SerializeField] private Light luce;
    [SerializeField] private Slider sliderVolume;
    [SerializeField] private Slider sliderLight;
    private float _currentvalueV, _currentvalueL;
    [SerializeField] private TextMeshProUGUI _volume;
    [SerializeField] private TextMeshProUGUI _light;

    void Start()
    {
        sliderVolume.onValueChanged.AddListener(ImpostaVolume);
        sliderLight.onValueChanged.AddListener(ImpostaLight);
    }
    void ImpostaVolume(float valore)
    {
        AudioListener.volume = valore;
        _currentvalueV = valore;
        _volume.text = _currentvalueV.ToString("F0");
    }

    void ImpostaLight(float valore)
    {
        luce.intensity = valore;
        _currentvalueL = valore;
        _light.text = _currentvalueL.ToString("F0");
    }
}
