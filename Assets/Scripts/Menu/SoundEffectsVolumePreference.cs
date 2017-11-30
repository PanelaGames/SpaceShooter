using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffectsVolumePreference : MonoBehaviour
{

    public void Start()
    {
        Slider soundEffectsVolumeSlider = GetComponent<Slider>();
        soundEffectsVolumeSlider.value = PlayerPrefs.GetFloat("Sound Effects Volume", 1f);
        soundEffectsVolumeSlider.onValueChanged.AddListener(
            delegate
            {
                PlayerPrefs.SetFloat("Sound Effects Volume", soundEffectsVolumeSlider.value);
                VolumeControllerEventSystem.BroadcastVolumeChange();
            }
        );
    }
}
