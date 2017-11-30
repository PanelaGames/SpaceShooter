using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterVolumePreference : MonoBehaviour
{
    public void Start()
    {
        Slider masterVolumeSlider = GetComponent<Slider>();
        masterVolumeSlider.value = PlayerPrefs.GetFloat("Master Volume", 1f);
        masterVolumeSlider.onValueChanged.AddListener(
            delegate
            {
                PlayerPrefs.SetFloat("Master Volume", masterVolumeSlider.value);
                VolumeControllerEventSystem.BroadcastVolumeChange();
            }
        );
    }
}
