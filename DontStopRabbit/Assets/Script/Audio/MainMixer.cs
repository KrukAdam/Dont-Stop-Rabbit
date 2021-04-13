using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMixer : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer = null;
    [SerializeField] Slider masterSlider = null;
    [SerializeField] Slider musicSlider = null;
    [SerializeField] Slider soundSlider = null;

    private void Start()
    {
        float volume;
        audioMixer.GetFloat("MasterVolume", out volume);
        masterSlider.value = volume;
        audioMixer.GetFloat("MusicVolume", out volume);
        musicSlider.value = volume;
        audioMixer.GetFloat("SoundVolume", out volume);
        soundSlider.value = volume;
    }
    public void SetMusic(float value)
    {
        audioMixer.SetFloat("MusicVolume", value);
    }
    public void SetSound(float value)
    {
        audioMixer.SetFloat("SoundVolume", value);
    }
    public void SetMaster(float value)
    {
        audioMixer.SetFloat("MasterVolume", value);
    }
}
