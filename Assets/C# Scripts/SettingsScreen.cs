using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsScreen : MonoBehaviour
{
    public Toggle fullscreenToggle;
    public Slider volumeSlider;
    public TMP_Text fpsLabel;

    // Start is called before the first frame update
    void Start()
    {
       fullscreenToggle.isOn = Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        Screen.fullScreen = fullscreenToggle.isOn;
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }

    public void increaseFPS()
    {
        Application.targetFrameRate = 144;
        fpsLabel.text = "144";
    }

    public void decreaseFPS()
    {
        Application.targetFrameRate = 60;
        fpsLabel.text = "60";
    }
}
