using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustSoundEffectsVolume : MonoBehaviour
{
    public void Start()
    {
        AdjustVolume();
    }
    public void OnEnable()
    {
        VolumeControllerEventSystem.OnSoundEffectsVolumeChanged += AdjustVolume;
    }
    public void OnDisable()
    {
        VolumeControllerEventSystem.OnSoundEffectsVolumeChanged -= AdjustVolume;
    }
    public void AdjustVolume()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume", 1f) * PlayerPrefs.GetFloat("Sound Effects Volume", 1f);
    }
}
