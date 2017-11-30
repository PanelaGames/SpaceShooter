using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustMusicVolume : MonoBehaviour
{
    public void Start()
    {
        AdjustVolume();
    }
    public void OnEnable()
    {
        VolumeControllerEventSystem.OnMusicVolumeChanged += AdjustVolume;
    }
    public void OnDisable()
    {
        VolumeControllerEventSystem.OnMusicVolumeChanged -= AdjustVolume;
    }
    public void AdjustVolume()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume", 1f) * PlayerPrefs.GetFloat("Music Volume", 1f);
    }
}
