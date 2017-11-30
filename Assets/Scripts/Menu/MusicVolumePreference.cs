using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolumePreference : MonoBehaviour
{
    public void Start()
    {
        Slider musicVolumeSlider = GetComponent<Slider>();
        musicVolumeSlider.value = PlayerPrefs.GetFloat("Music Volume", 1f);
        musicVolumeSlider.onValueChanged.AddListener(
            delegate
            {
                PlayerPrefs.SetFloat("Music Volume", musicVolumeSlider.value);
                VolumeControllerEventSystem.BroadcastVolumeChange();
            }
        );
    }
}
