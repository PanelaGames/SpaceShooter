using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControllerEventSystem : MonoBehaviour
{
    public delegate void MasterVolumeChanged();
    public static event MasterVolumeChanged OnMasterVolumeChanged;
    public delegate void MusicVolumeChanged();
    public static event MusicVolumeChanged OnMusicVolumeChanged;
    public delegate void SoundEffectsVolumeChanged();
    public static event SoundEffectsVolumeChanged OnSoundEffectsVolumeChanged;

    public static void BroadcastVolumeChange()
    {
        if (OnMasterVolumeChanged != null)
            OnMasterVolumeChanged();
        if (OnMusicVolumeChanged != null)
            OnMusicVolumeChanged();
        if (OnSoundEffectsVolumeChanged != null)
            OnSoundEffectsVolumeChanged();
    }
}
