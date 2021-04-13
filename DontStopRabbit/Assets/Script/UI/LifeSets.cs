using UnityEngine;
using UnityEngine.UI;

public class LifeSets : MonoBehaviour
{
    [SerializeField] Slider healthSlider = null;
    [SerializeField] Text healthTextView = null;
    [SerializeField] PlayersSettings playersSettings = null;
    int sliderValue = 1;

    private void Start()
    {
        sliderValue = playersSettings.GetPlayerLife();
        healthTextView.text = sliderValue.ToString();
        healthSlider.value = sliderValue;
    }
    public void SliderChange()
    {
        sliderValue = (int)healthSlider.value;
        healthTextView.text = sliderValue.ToString();
        playersSettings.PlayersLifes(sliderValue);
    }
}
